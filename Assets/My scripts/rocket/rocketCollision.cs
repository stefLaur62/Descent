using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketCollision : MonoBehaviour
{
    public GameObject explosionPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void launchAnim(ContactPoint contact)
    {
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        Instantiate(explosionPrefab, pos, rot);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject);

        //start anim
        launchAnim(collision.contacts[0]);

        Destroy(gameObject);
    }
}
