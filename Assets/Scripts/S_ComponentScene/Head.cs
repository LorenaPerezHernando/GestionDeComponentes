using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]   
public class Head : MonoBehaviour
{
    [System.NonSerialized]
    public Rigidbody myRigidbody;

    private void Awake() 
    {
        myRigidbody = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        print("Hello " + name);

    }

    private void Update()
    {
         
    }
    public void AddForce(float force)
    {
        GetComponent<Rigidbody>().AddForce(0, force, 0); 
    }
}
