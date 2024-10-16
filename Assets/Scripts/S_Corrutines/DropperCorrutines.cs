using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperCorrutines : MonoBehaviour
{
    //Attributes
    public float repeatRate = 1;
    public GameObject ballPrefabs; 
    void Start()
    {
        StartCoroutine(Drop(repeatRate));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Drop(float Rate)
    {
        yield return null; //Espera de un frame 
    }
}
