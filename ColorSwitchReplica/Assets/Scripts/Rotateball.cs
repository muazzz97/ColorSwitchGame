using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotateball : MonoBehaviour
{
    public float rotate;
  
     void Update()
    {
        transform.Rotate(0, 0, rotate *Time.deltaTime);
        //transform.RotateAround(transform.eulerAngles*Time.deltaTime, 100);
    }
}
