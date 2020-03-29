using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Movement : MonoBehaviour
{
    public Transform target;
    public Transform waypoint1;
    public Transform waypoint2;
    public float speed=2;
    private bool direction = false;
    

    void Update()
    {
        float step = speed * Time.deltaTime;
        if (!direction)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoint1.position, step);
            if (transform.position == waypoint1.position)
                direction = !direction;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoint2.position, step);
            if (transform.position == waypoint2.position)
                direction = !direction;
        }
        transform.LookAt(target);
    }
}
