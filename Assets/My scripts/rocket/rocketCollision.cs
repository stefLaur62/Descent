using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketCollision : MonoBehaviour
{
    public GameObject explosionPrefab;

    private void launchAnim(ContactPoint contact)
    {
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        Instantiate(explosionPrefab, pos, rot);
    }

    private void OnCollisionEnter(Collision collision)
    {

        //start anim
        launchAnim(collision.contacts[0]);

        Destroy(gameObject);
    }
}
