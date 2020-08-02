using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BulletShooter : MonoBehaviour
{
    //Audio types
    public AudioClip bulletSound;
    public AudioClip fastSound;
    public AudioClip bombSound;
    public AudioClip missileSound;
    public AudioSource audioSource;
    // list for diff types of bullets
    public List<Transform> nozzles;

    public GameObject bulletPrefab;
    public GameObject fastBulletPrefab;
    public GameObject bombPrefab;
    public GameObject missilePrefab; 

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
            audioSource.PlayOneShot(bulletSound);
        }
        // if 2 is pressed, fast bullet is spawned
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (int i = 0; i < nozzles.Count; i++)
            {
                Instantiate(fastBulletPrefab, nozzles[i].transform.position, transform.rotation);
                
            }
            audioSource.PlayOneShot(fastSound);
        }
        // if 3 is pressed, bomb is spawned
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            for (int i = 0; i < nozzles.Count; i++)
            {
                Instantiate(bombPrefab, nozzles[i].transform.position, transform.rotation);
                
            }
            audioSource.PlayOneShot(bombSound);
        }
        // if 4 is pressed, missile bullet is spawned
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            for (int i = 0; i < nozzles.Count; i++)
            {
                Instantiate(missilePrefab, nozzles[i].transform.position, transform.rotation);

            }
            audioSource.PlayOneShot(missileSound);
        }
    }
}
