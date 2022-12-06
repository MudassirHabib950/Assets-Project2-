using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound=30.0f;
    private float lowerBound=-10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if the player goes past of object remove that object
        if(transform.position.z>topBound)
        {
            Destroy(gameObject);
        } else if(transform.position.z<lowerBound)
        {
           
            Destroy(gameObject);

        }
        
        
        
    }
}