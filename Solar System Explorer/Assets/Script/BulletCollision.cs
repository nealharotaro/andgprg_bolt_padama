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

    public float placeX;
    public float placeY = 109;
    public float placeZ = 0;

    public List<GameObject> powerUps;

    [SerializeField] public int maxHp;
    public int currentHp; 

    public int damage;
    private int time;
    private int powerRando;
    private int multiplier;

    // Start is called before the first frame update
    void Start()
    {
        powerRando = Random.Range(0,2);
        currentHp = maxHp;
        if(CompareTag("Player"))
        {
            healthBar.SetMaxHP(maxHp);
        }
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(SpawnPower());
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) // comparing the tag, if bullet, proceed
        {
            currentHp -= damage;
            if(CompareTag("Player")){
                healthBar.SetHealth(currentHp);
            }
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
                    
                    Score.scoreValue ++;
                    audioSource.PlayOneShot(desSound);
                    audioSource.PlayOneShot(scoreSound);
                }
                else if (CompareTag("Player"))
                {
                    currentHp = 0;
                    //destroys the targer
                    Destroy(this.gameObject);
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
        }

        if(collision.gameObject.CompareTag("Player"))
        {
            if(collision.gameObject.CompareTag("PowerUp"))
            {
            Destroy(collision.gameObject);

               // double damage
            if(powerRando == 0)
            {
                while(time >= 0)
                {
                    damage *= 2;
                    time = 0;
                }
            }

            // hp add
            else if  (powerRando == 1)
            {
                multiplier = Random.Range(1, 3);
                currentHp += multiplier;
            }

            //movement speed
            else if (powerRando == 2)
            {
                while(time >= 0)
                {
                    Movement.movementSpeed *= 2;
                    Movement.movementSpeed = 0;
                }
            }
            }
        }
    }   

    IEnumerator SpawnPower()
    {
        placeX = Random.Range(-30, 25);
        Instantiate(powerUps[powerRando], new Vector3(placeX, placeY, placeZ), transform.rotation);
        yield return new WaitForSeconds(5);
    }

    // Update is called once per frame
    void Update()
    {
        powerRando = Random.Range(0,2);
        SpawnPower();
    }
}
