using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinrotate : MonoBehaviour
{
    float rotatespeed = 60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotatespeed * Time.deltaTime, 0);
    }
}
