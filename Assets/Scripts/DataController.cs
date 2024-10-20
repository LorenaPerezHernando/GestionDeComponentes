using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataController : MonoBehaviour
{
    //Struct
    [System.Serializable]
    public struct DataBucket
    {
        public int explosionCount;
        public int spawnCount;
        public int collisionCount;

        public void Save(string path)
        {
            string json = JsonUtility.ToJson(this);
            File.WriteAllText(path, json);
        }
    }
    public DataBucket bucket;

    private void Start()
    {
        bucket.explosionCount = 0;
        bucket.spawnCount = 0;
        bucket.collisionCount = 0;
    }
    private void OnDestroy()
    {
        bucket.Save(Application.dataPath + "/Data/data.txt"); 
    }

    public void SendData(KPIType dataType)
    {
        switch (dataType)
        {
            case KPIType.CollisionKPI:
                bucket.collisionCount++;
                break;
            case KPIType.ExplosionsKPI:
                bucket.explosionCount++;
                break;
            case KPIType.SpawnedBallKPI:
                bucket.spawnCount++;
                break;
        }
            
    }
}
