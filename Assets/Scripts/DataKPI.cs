using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KPIType
{
    CollisionKPI = 0,
    SpawnedBallKPI = 1,
    ExplosionsKPI = 2,

}
public class DataKPI : MonoBehaviour
{
    public KPIType customKPI;
    private DataController dataController;

    //Methods
    private void Awake()
    {
        dataController = FindObjectOfType<DataController>();
    }
    public void SendData()
    {
        print("Datos recibidos" +customKPI); 
        dataController.SendData(customKPI);
    }
}
