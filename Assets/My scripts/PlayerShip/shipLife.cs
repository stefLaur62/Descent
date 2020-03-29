using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shipLife : MonoBehaviour
{
    private int damage = 0;
    private int life = 0;
    public Text dmg;
    public Text lifen;
    public GameObject deathCanvas;

    void Update()
    {
        if (damage > 99)
        {
            if(life == 0)
            {
                deathCanvas.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                //anim degat 
                life--;
                lifen.text = life.ToString();
                damage = 0;
                dmg.text = damage + "%";
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Rocket")
        {
            damage += 20;
            dmg.text = damage + "%";
        }
        if (collision.gameObject.tag == "Heart")
        {
            life++;
            damage = 0;
            lifen.text = life.ToString();
            Destroy(collision.gameObject);
        }
    }
}
