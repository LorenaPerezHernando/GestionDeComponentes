using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Attribute
    public float repeatRate = 1;
    public GameObject ballPrefab;

    private MyArray myArray;

    private void Awake()
    {
        myArray = GetComponent<MyArray>();
    }
    void Start()
    {
        InvokeRepeating(nameof(Drop), 0, repeatRate); 
    }

    void Drop()
    {
        //Guardamos la bola instanciada en ball, aunque no hagamos nada con ella 
        GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
    }
}
