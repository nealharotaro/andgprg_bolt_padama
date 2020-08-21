using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class BulletShooter : MonoBehaviour
{
    //Audio types
    public AudioClip bulletSound;
    public AudioSource audioSource;

    // list for diff nozzle areas
    public List<Transform> nozzles;

    public GameObject bulletPrefab;

    public int bulletCount;
    Text bulletsAvailable;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        bulletsAvailable = GetComponent<Text>();
    }

    public void Fire()
    {
        // if Space is pressed, first bullet(basic) is spawned
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < nozzles.Count; i++) // to make the loop stop at the designated list count
            {
                Instantiate(bulletPrefab, nozzles[i].transform.position, transform.rotation);
            }
            // per fire reduce 1 bullet from the count
            bulletCount--;
            audioSource.PlayOneShot(bulletSound);
            bulletsAvailable.text = "Bullets: " + bulletCount;
        }
    }

    void Reload()
    {
        if (bulletCount >= 0)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                bulletCount = 5;
                bulletsAvailable.text = "Bullets: " + bulletCount;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // checks if bullet is 0, if its not, fire
        if (bulletCount > 0)
        {
            Fire();
        }
        Reload();
    }
}
