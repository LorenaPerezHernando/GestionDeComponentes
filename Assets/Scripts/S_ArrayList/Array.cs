using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public GameObject[] objectArray = new GameObject[5];
    private int index = 0; //La posicion de cada objeto del array
    public void AddObject(GameObject newObject)
    {
        objectArray[index] = newObject; //Guardar un objeto en un array 
        index++;
    }
}
