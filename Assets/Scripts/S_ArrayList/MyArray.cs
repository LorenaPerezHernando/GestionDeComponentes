using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyArray : MonoBehaviour
{
    //Atttributes
    public string[] daysArray = new string[] { "lunes", "martes", "miercoles", "jueves", "viernes", "Sabado", "domingo" };
    

    public GameObject[] objectArray = new GameObject[5];
    public GameObject[] objectArrayInspector; 

    //Private
    private int index = 0; //La posicion de cada objeto del array
    private int indexInspector = 0; 

    //Method
    public void AddObject(GameObject newObject)
    {
        if(index < objectArray.Length)
        {
            objectArray[index] = newObject; //Guardar un objeto en posicion 0  
            index++;

        }

        if (index < objectArrayInspector.Length)
        {
            objectArrayInspector[indexInspector] = newObject; //Guardar un objeto en posicion 0  
            indexInspector++;

        }
    }
}
