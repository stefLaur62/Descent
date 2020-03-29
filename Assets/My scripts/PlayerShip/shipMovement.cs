using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMovement : MonoBehaviour
{
    public Vector3 MousePosition;
    public float curShipSpeed = 0.0f;
    public float step = 1f;
    public float current_speed = 0f;
    public int maxSpeed = 8;
    public float agility = 0.5f;
    public float rotate_speed = 1.5f;
    public float mouse_rotate = 0.15f;
    public Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        MousePosition = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 0, -rotate_speed);
        }

        if (Input.GetKey("q"))
        {
            transform.Rotate(0, 0, rotate_speed);
        }
        if ((Input.GetKey("up") || Input.GetKey("z")) && (current_speed < maxSpeed))
        {
            current_speed += step;
        }
        else if ((Input.GetKey("down") || Input.GetKey("s")) && (current_speed > 0))
        {
            current_speed -= step * 3;
            if (current_speed < 0)
                current_speed = 0;
        }
        //fix mouse pos higher than screen
        MousePosition = Input.mousePosition;
        MousePosition.x = (Screen.height / 2) - Input.mousePosition.y;
        if (MousePosition.x > Screen.height)
            MousePosition.x = Screen.height;
        MousePosition.y = -(Screen.width / 2) + Input.mousePosition.x;
        if (MousePosition.y > Screen.width)
            MousePosition.y = Screen.width;
        transform.Rotate(MousePosition * Time.deltaTime * mouse_rotate, Space.Self);

        curShipSpeed = Mathf.Lerp(curShipSpeed, current_speed, Time.deltaTime * step);
        transform.position += transform.TransformDirection(Vector3.forward) * curShipSpeed * Time.deltaTime;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Rocket" && collision.gameObject.tag != "Heart")
        {
            curShipSpeed = 0;
            current_speed = 0;
            body.velocity = Vector3.zero;
        }
    }

}