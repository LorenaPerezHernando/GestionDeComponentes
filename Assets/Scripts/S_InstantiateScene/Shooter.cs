using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [Header ("Movement")]
    public Ball ballPrefab;

    [Header ("Shoot")]
    public Transform spawnPoint;
    public float speedRotation = 100;
    public float shootForce = 1000;

    private Quaternion initialRotation;

    private void Awake()
    {
        
    }
    void Start()
    {
        Invoke(nameof(InitialConfiguration), 0.1f);
    }

    void Update()
    {
        //Movement
        transform.Rotate(Input.GetAxis("Mouse X") * Time.deltaTime * speedRotation * Vector3.left);
        transform.Rotate(Input.GetAxis("Mouse Y") * Time.deltaTime * speedRotation * Vector3.down);
            //ClampRotation
        transform.localRotation = Quaternion.Euler(transform.localRotation.eulerAngles.x, transform.localRotation.eulerAngles.y,0 );

        //Spawn && AddForce
        if (Input.GetMouseButtonUp(0))
        {
            Ball ball = Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
            ball.myrigidbody.AddForce(transform.forward * shootForce);
        }
    }
    void InitialConfiguration()
    {
        initialRotation = transform.rotation;
    }
}
