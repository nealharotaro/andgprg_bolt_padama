using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public static int hp = 5;
    public List<Transform> nozzles;

    public GameObject bullet;
    public float delayBullet;

    public void Fire()
    {
        if (CompareTag("Enemy"))
        {
            while (delayBullet != 3)
            {
                delayBullet++;
                for (int i = 0; i < nozzles.Count; i++)
                {
                    Instantiate(bullet, nozzles[i].transform.position, transform.rotation);
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }
}
