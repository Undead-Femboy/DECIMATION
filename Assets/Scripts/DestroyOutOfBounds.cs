using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float upperBound;
    public float lowerBound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > upperBound)
        {
            Debug.Log("Hit the upper");
            Destroy(gameObject);
            
        }

        if (transform.position.y < lowerBound)
        {
            Debug.Log("Hit the lower");
            Destroy(gameObject);
        }
    }
}
