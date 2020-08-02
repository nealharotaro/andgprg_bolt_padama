using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject sphere;

    public AudioClip enterSound;
    public AudioClip exitSound; 
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            GameObject sphereBall = Instantiate(sphere, spawnPoint.transform.position, transform.rotation);
            Destroy(sphereBall, 1);
            audioSource.PlayOneShot(enterSound);
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        Destroy(collider.gameObject);
        audioSource.PlayOneShot(exitSound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
