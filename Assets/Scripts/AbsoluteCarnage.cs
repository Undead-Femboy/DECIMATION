using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AbsoluteCarnage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestroyAllEnemies()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject hornet in enemies)
        {
            Destroy(hornet);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DestroyAllEnemies();
            Destroy(gameObject);
        }
    }




}
