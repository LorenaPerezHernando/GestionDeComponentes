using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    [System.NonSerialized]
    public Rigidbody myrigidbody;

    private void Awake()
    {
        myrigidbody = GetComponent<Rigidbody>();
        
    }
   
}
