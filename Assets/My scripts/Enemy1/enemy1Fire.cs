using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1Fire : MonoBehaviour
{
    private float fireRate = 0.4f;
    private float nextFire = -1f;

    public GameObject rocket;
    public GameObject spawn;
    public Transform ship;
    void Start()
    {
    }

    void Update()
    {
        if (nextFire > 0)
        {
            nextFire -= Time.deltaTime;
            return;
        }
        else
        {
            SpawnMissile();
        }
    }
    private void SpawnMissile()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            float dist = Vector3.Distance(transform.position, ship.position);
            if (dist < 10)
            {
                GameObject shot = Instantiate(rocket, spawn.transform.position, spawn.transform.rotation);
                shot.transform.Rotate(new Vector3(90, 0, 0));
                WeaponWasFired();
            }
        }
    }

    void WeaponWasFired()
    {
        nextFire = fireRate;
    }
}
