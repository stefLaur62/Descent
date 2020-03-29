using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1Fire : MonoBehaviour
{
    private float fireRate = 1.5f;
    private float nextFire = -2f;

    public GameObject rocket;
    public GameObject spawn;
    public Transform ship;
    public Transform alien;
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
        float dist = Vector3.Distance(transform.position, ship.position);
        if (dist < 10)
        {
            transform.LookAt(ship);
            GameObject shot = Instantiate(rocket, spawn.transform.position, alien.transform.rotation);
            shot.transform.Rotate(90,0,0);
            WeaponWasFired();
        }
    }

    void WeaponWasFired()
    {
        nextFire = fireRate;
    }
}
