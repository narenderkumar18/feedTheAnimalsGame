using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float topBoundary = 30.0f;
    private float downBoundary = -14.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(transform.position.z > topBoundary)
        {
            Destroy(gameObject);

        }
     else if(transform.position.z < downBoundary)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
        
    }

}
