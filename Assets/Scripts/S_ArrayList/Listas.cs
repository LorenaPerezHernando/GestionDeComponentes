using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listas : MonoBehaviour
{
    public int limitObjects = 7;
    public List<GameObject> objectList = new List<GameObject>(); //SIEMPRE INICIALIZAR, pq sino dan problemas

    public GameObject explosionPrefab; 
    public void AddObject(GameObject ball)
    {
        objectList.Add(ball);
        if(objectList.Count > limitObjects)
        {
            ExplosionAll();
           
        }
    }

    private void ExplosionAll()
    {
        //Las listas se recorren con bucles for
        for(int i = 0; i < objectList.Count; i++)
        {
            Destroy(objectList[i]); //la forma de acceder es igual que array
            Instantiate(explosionPrefab, objectList[i].transform.position, Quaternion.identity); 
            //Se puede poner al final pq se actualiza al final del frame 
        }
        objectList.Clear();
    }
}
