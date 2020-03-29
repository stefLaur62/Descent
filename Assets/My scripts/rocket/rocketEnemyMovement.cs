using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketEnemyMovement : MonoBehaviour
{
    float BulletSpeed = 3f;

    void Update()
    {
        transform.position += transform.up * Time.deltaTime * BulletSpeed;
    }
}
