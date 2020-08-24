using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject enemy;

    public float placeX;
    public float placeY = 109;
    public float placeZ;
    private int enemyCount;

    public List<GameObject> enemyList;
    public int index;
    public List<int> scoreList;

    // Use this for initialization
    void Start()
    {
        index = Random.Range(0, 4);
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while(enemyCount < 5)
        {
            placeX = Random.Range(-30, 25);
            placeZ = Random.Range(50, 234);
            Instantiate(enemyList[index], new Vector3(placeX, placeY, placeZ), transform.rotation);
            enemyCount += 1;
            yield return new WaitForSeconds(2);
        }
    }

    void Update()
    {
        index = Random.Range(0, 4);
        SpawnEnemy();
        enemyCount = 0;
    }
}
