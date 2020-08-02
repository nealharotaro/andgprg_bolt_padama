using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            GameObject sphereBall = Instantiate(sphere, spawnPoint.transform.position, transform.rotation);
            Destroy(sphereBall, 1);
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        Destroy(collider.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
