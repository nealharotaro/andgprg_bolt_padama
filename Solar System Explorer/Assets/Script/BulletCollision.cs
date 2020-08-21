using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public AudioClip desSound;
    public AudioClip scoreSound;
    public AudioSource audioSource;

    public int hp; 

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) // comparing the tag, if bullet, proceed
        {
            hp -= 1;
            //destroy bullet after colliding the target
            Destroy(collision.gameObject);

            //checks hp
            if (hp <= 0)
            {
                if(CompareTag("Enemy"))
                {
                    hp = 0;
                    //destroys the target if hp reaches 0
                    Destroy(this.gameObject);

                    //when target is destroyed, score is gained
                    Score.scoreValue += 1;
                    audioSource.PlayOneShot(desSound);
                    audioSource.PlayOneShot(scoreSound);
                }
                else if (CompareTag("Player"))
                {
                    hp = 0;
                    //destroys the targer
                    Destroy(this.gameObject);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
