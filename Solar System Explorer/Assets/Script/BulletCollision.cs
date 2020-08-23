using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class BulletCollision : MonoBehaviour
{
    public AudioClip desSound;
    public AudioClip scoreSound;
    public AudioSource audioSource;
    public Health healthBar;
    public SpawnPoint spawnPoint;

    public List<GameObject> powerUps;

    [SerializeField] public int maxHp;
    public int currentHp; 

    public int damage;
    private int powerRando;
    private int rand;

    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(0, 1);
        powerRando = Random.Range(0,4);
        currentHp = maxHp;
        healthBar.SetMaxHP(maxHp);
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) // comparing the tag, if bullet, proceed
        {
            currentHp -= damage;
            healthBar.SetHealth(currentHp);
            //destroy bullet after colliding the target
            Destroy(collision.gameObject);

            //checks currentHp
            if (currentHp <= 0)
            {
                if(CompareTag("Enemy"))
                {
                    currentHp = 0;
                    //destroys the target if currentHp reaches 0
                    Destroy(this.gameObject);

                    //when target is destroyed, score is gained
                    
                    AddScore();
                    audioSource.PlayOneShot(desSound);
                    audioSource.PlayOneShot(scoreSound);
                }
                else if (CompareTag("Player"))
                {
                    currentHp = 0;
                    //destroys the targer
                    Destroy(this.gameObject);
                    //SceneManagement.LoadScene();
                }
            }
        }
    }   

    void AddScore()
    {
        if(spawnPoint.index == 0)
        {
            Score.scoreValue += 100;
        }
        else if(spawnPoint.index == 1)
        {
            Score.scoreValue += 50;
        }
        else if(spawnPoint.index == 2)
        {
            Score.scoreValue += 300;
        }
        else if(spawnPoint.index == 3)
        {
            Score.scoreValue += 200;
        }
        else if(spawnPoint.index == 4)
        {
            Score.scoreValue += 250;
        }
    }

    /*void SpawnPowerup()
    {
        if(rand == 1)
        {
            Instantiate(powerUps[powerRando], new Vector3(placeX, placeY, placeZ), transform.rotation);
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
