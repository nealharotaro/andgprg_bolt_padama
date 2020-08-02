using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    public List<Transform> nozzles;

    public GameObject bulletPrefab;
    public GameObject fastBulletPrefab;
    public GameObject bombPrefab;
    public GameObject missilePrefab; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            for(int i = 0; i < nozzles.Count; i++)
            {
                Instantiate(bulletPrefab, nozzles[i].transform.position, transform.rotation);
            }
            /*
            Instantiate(bulletPrefab, nozzle1.transform.position, transform.rotation);
            Instantiate(bulletPrefab, nozzle2.transform.position, transform.rotation);
            Instantiate(bulletPrefab, nozzle3.transform.position, transform.rotation);
            Instantiate(bulletPrefab, nozzle4.transform.position, transform.rotation);*/

        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < nozzles.Count; i++)
            {
                Instantiate(fastBulletPrefab, nozzles[i].transform.position, transform.rotation);
            }
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            for (int i = 0; i < nozzles.Count; i++)
            {
                Instantiate(bombPrefab, nozzles[i].transform.position, transform.rotation);
            }
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            for (int i = 0; i < nozzles.Count; i++)
            {
                Instantiate(missilePrefab, nozzles[i].transform.position, transform.rotation);
            }
        }
    }
}
