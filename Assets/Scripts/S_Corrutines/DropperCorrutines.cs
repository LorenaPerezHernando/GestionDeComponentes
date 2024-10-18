using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperCorrutines : MonoBehaviour
{
    //Attributes
    public GameObject ballPrefabs;
    private MyArray myArray;

    public float minRange = 0;
    public float maxRange = 2; 

    //Methods
    private void Awake()
    {
        myArray = GetComponent<MyArray>();
    }
    void Start()
    {
        float repeatRate = Random.Range(minRange, maxRange);
        StartCoroutine(Drop(repeatRate));
    }

    IEnumerator Drop(float rateTime)
    {

        while (true)
        {
            //yield return null; //Espera de un frame 
            //yield return rateTime; //Espera el tiempo de spawn

            yield return new WaitForSeconds(rateTime);
            float probability = Random.Range(0, 3);
            if(probability == 0)
            {
                GameObject ball = Instantiate(ballPrefabs, transform.position, Quaternion.identity);
                if(myArray != null)
                {
                    myArray.AddObject(ball);
                }
            }
        }
    }
}
