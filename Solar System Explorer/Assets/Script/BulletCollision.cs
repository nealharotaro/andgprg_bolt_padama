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

    [SerializeField] public int maxHp;
    public int currentHp; 

    // Start is called before the first frame update
    void Start()
    {
        currentHp = maxHp;
        healthBar.SetMaxHP(maxHp);
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) // comparing the tag, if bullet, proceed
        {
            currentHp--;
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
                    Score.scoreValue += 1;
                    audioSource.PlayOneShot(desSound);
                    audioSource.PlayOneShot(scoreSound);
                }
                else if (CompareTag("Player"))
                {
                    currentHp = 0;
                    //destroys the targer
                    Destroy(this.gameObject);
                    SceneManagement.LoadScene();
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
