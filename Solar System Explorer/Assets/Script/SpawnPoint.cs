using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject enemy;

    public float placeX;
    public float placeY = 109;
    public float placeZ = 233;
    public float enemyCount;

    public GameObject[] PooledObject;
    public List<GameObject> enemyList;
    public Transform[] SpawnLocations;
    public float MinimumSpawnRate;
    public float MaximumSpawnRate;
    public int NumberOfObjects = 1;
    public int index;
    private int spawnLocationIndex;

    // Use this for initialization
    void Start()
    {
        /*SetObjects();
        StartCoroutine(SpawnEnemy());*/
        index = Random.Range(0, 4);
        StartCoroutine(SpawnEnemy());
    }



    /*void SetObjects()
    {
        index = 0;

        for (int i = 0; i < PooledObject.Length * NumberOfObjects; i++)
        {
            GameObject objects = Instantiate(PooledObject[index], new Vector3(placeX, placeY, placeZ), Quaternion.identity); // Spawn object prefabs
            PooledObjectList.Add(objects); // Add prefabs to the Pool object list
            PooledObjectList[i].SetActive(false); // Set prefabs as deactivated
            index++;

            // For the sake of multiplying the objects to the number of objects
            if (index == PooledObject.Length)
            {
                index = 0; // Resets index
            }
        }
    }*/

    IEnumerator SpawnEnemy()
    {
        while(enemyCount < 10)
        {
            placeX = Random.Range(-45, 37);
            Instantiate(enemyList[index], new Vector3(placeX, placeY, placeZ), transform.rotation);
            yield return new WaitForSeconds(1);
            enemyCount += 1;
        }
        index = Random.Range(0, 4);
    }

    void Update()
    {
        StartCoroutine(SpawnEnemy());
    }
}
