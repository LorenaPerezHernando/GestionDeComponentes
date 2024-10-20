using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    [System.NonSerialized]
    public Rigidbody myrigidbody;
    public DataKPI kpiData;

    private void Awake()
    {
        myrigidbody = GetComponent<Rigidbody>();
        kpiData = GetComponent<DataKPI>();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(kpiData != null)
            kpiData.SendData();
    }

}
