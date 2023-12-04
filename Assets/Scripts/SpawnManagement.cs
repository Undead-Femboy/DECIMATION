using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagement : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private float spawnRangeX = 23;
    




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPos = new Vector3(transform.position.x + Random.Range(-spawnRangeX, spawnRangeX), transform.position.y, transform.position.z);
            Instantiate(obstaclePrefab, spawnPos, transform.rotation);
        }
    }
}
