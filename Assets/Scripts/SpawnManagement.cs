using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagement : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private float spawnRangeX = 23;
    public GameObject[] enemyPrefabs;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {
        int enmyIndex = Random.Range(0, enemyPrefabs.Length);
        Vector3 spawnPos = new Vector3(transform.position.x + Random.Range(-spawnRangeX, spawnRangeX), transform.position.y, transform.position.z);
        Instantiate(obstaclePrefab, spawnPos, transform.rotation);
        
    }




}
