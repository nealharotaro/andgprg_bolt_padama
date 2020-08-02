using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public static int hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            hp -= 1;
            //destroy bullet after colliding the target
            Destroy(collision.gameObject);

            //checks hp
            if (hp <= 0)
            {
                hp = 0;
                //destroys the target if hp reaches 0
                Destroy(this.gameObject);

                //when target is destroyed, score is gained
                Score.scoreValue += 1;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
