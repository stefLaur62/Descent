using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketMovement : MonoBehaviour
{
    float BulletSpeed = 10f;
 
    void Update()
    {
        transform.position +=  transform.up * Time.deltaTime * BulletSpeed;
    }
}
