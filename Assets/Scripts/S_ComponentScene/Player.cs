using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   //Attributes
   private Body body;
   private Head head;

    public float headForce = 100; 


    void Start()
    {
        body = GetComponentInChildren<Body>(true);
        head = GetComponentInChildren<Head>(true);
        head.GetComponent<Rigidbody>();

        body.gameObject.SetActive(true);
        head.gameObject.SetActive(true);
    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            head.AddForce(500); 

        body.transform.Translate(Input.GetAxis("Horizontal" )  * Time.deltaTime * 5 , 0 , Input.GetAxis("Vertical") * Time.deltaTime * 5);

       
    }
    private void FixedUpdate()
    {
        //Vector direccion es = Posicion de destino - mi posicion
        Vector3 headDirection = body.transform.position - head.transform.position;
        head.myRigidbody.AddForce(headDirection * headForce);
    }
}
