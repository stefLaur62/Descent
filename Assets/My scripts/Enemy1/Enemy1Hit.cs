using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Hit : MonoBehaviour
{
    //public AudioSource audio;
    //public AudioClip audio2;

    void Start()
    {
        //audio = GetComponent<AudioSource>();
        //audio.clip = audio2;
    }
    private void playSound()
    {
        //audio.Play();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Rocket")
        {
            //playSound();
            Destroy(gameObject);
        }
    }
}
