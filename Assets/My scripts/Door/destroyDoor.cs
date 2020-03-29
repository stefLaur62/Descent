using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyDoor : MonoBehaviour
{
    public GameObject doorL;
    public GameObject doorR;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Rocket")
        {
            Destroy(doorL);
            Destroy(doorR);
        }
    }
}
