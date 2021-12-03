using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Balllocation;

    // Update is called once per frame
    void Update()
    { 
     if (Balllocation.transform.position.y > transform.position.y )
        {
            transform.position = new Vector3(transform.position.x, Balllocation.transform.position.y, transform.position.z);
              
     }
    }
}
