using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketFire : MonoBehaviour
{
    private float fireRate = 0.4f;
    private float nextFire = -1f;

    public GameObject rocket;
    public GameObject left_spawn;
    public GameObject right_spawn;

    private AudioSource audio;
    public AudioClip audio2;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.clip = audio2;
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
            GameObject rocket_left = Instantiate(rocket, left_spawn.transform.position, left_spawn.transform.rotation);
            rocket_left.transform.Rotate(new Vector3(90, 0, 0));

            GameObject rocket_right = Instantiate(rocket, right_spawn.transform.position, right_spawn.transform.rotation);
            rocket_right.transform.Rotate(new Vector3(90, 0, 0));

            audio.Play();
            WeaponWasFired();
        }
    }

    void WeaponWasFired()
    {
        nextFire = fireRate;
    }
}
