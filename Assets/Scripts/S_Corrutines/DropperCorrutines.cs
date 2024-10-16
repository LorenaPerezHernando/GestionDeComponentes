using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperCorrutines : MonoBehaviour
{
    //Attributes
    public GameObject ballPrefabs; 
    void Start()
    {
        float repeatRate = Random.Range(0.5f, 3f);
        StartCoroutine(Drop(repeatRate));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Drop(float rateTime)
    {

        while (true)
        {
            //yield return null; //Espera de un frame 
            //yield return rateTime; //Espera el tiempo de spawn

            yield return new WaitForSeconds(rateTime);
            GameObject ball = Instantiate(ballPrefabs, transform.position, Quaternion.identity);
        }
    }
}
