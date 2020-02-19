using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketMovement : MonoBehaviour
{
    float BulletSpeed = 3f;
    Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        /*dir = transform.forward;
        Debug.Log(transform.forward);
        Debug.Log(dir);*/
    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=  transform.up * Time.deltaTime * BulletSpeed;
    }
}
