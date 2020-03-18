using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapY : MonoBehaviour
{
    public float yspeed=5;
    // Use this for initialization
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, yspeed, 0);
    }
}
