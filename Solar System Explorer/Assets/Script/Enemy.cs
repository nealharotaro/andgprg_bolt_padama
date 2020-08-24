using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public List<Transform> nozzles;

    public GameObject bullet;
    public float delayBullet;

    private float elapsedTime;

        // Start is called before the first frame update
    void Start()
    {

    }

    void Fire()
    {
        if (CompareTag("Enemy"))
        {
            for (int i = 0; i < nozzles.Count; i++)
            {
                Instantiate(bullet, nozzles[i].transform.position, transform.rotation);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
            if(elapsedTime > 2)
            {
                Fire();
                elapsedTime = 0;
            }
        
    }
}
