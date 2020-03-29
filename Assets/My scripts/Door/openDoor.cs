using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    private bool isOpen;
    public Transform end;
    public GameObject door;
    public new AudioSource audio;

    void Update()
    {
        if(isOpen)
            moveDoor();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Rocket")
        {
            if (!isOpen)
            {
                audio.Play();
                isOpen = true;

            }
        }
    }
    private void moveDoor()
    {
        door.transform.position = Vector3.Lerp(door.transform.position, end.position, Time.deltaTime);
    }
}