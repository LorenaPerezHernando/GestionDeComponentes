using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(Rigidbody))]
public class GetComponents : MonoBehaviour
{
    public Color color; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Return))
            GetComponent<MeshRenderer>().material.color = color;

        if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(0, 200, 0);
            GetComponentInChildren<Head>().AddForce(300);
            //GetComponentInChildren<MeshRenderer>().enabled = false; //Encuentra primero el del padre y usa el del padre
            GetComponentInChildren<Head>().transform.Translate(1, 0, 0);

            Camera.main.fieldOfView *= 2; //Hace un zoom(inverso) de 2
            Camera.main.transform.Translate(0, 0, 5);
        }
    }
}
