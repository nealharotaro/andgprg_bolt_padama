using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    // list for diff types of bullets
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
        // Bullets are now in 1234 respectively, for UX purposes

        // if 1 is pressed, first bullet(basic) is spawned
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            for(int i = 0; i < nozzles.Count; i++) // to make the loop stop at the designated list count
            {
                Instantiate(bulletPrefab, nozzles[i].transform.position, transform.rotation);
            }

        }
        // if 2 is pressed, fast bullet is spawned
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (int i = 0; i < nozzles.Count; i++)
            {
                Instantiate(fastBulletPrefab, nozzles[i].transform.position, transform.rotation);
            }
        }
        // if 3 is pressed, bomb is spawned
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            for (int i = 0; i < nozzles.Count; i++)
            {
                Instantiate(bombPrefab, nozzles[i].transform.position, transform.rotation);
            }
        }
        // if 4 is pressed, missile bullet is spawned
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            for (int i = 0; i < nozzles.Count; i++)
            {
                Instantiate(missilePrefab, nozzles[i].transform.position, transform.rotation);
            }
        }
    }
}
