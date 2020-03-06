using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeExplosion : MonoBehaviour
{
    private float debut;
    // Start is called before the first frame update
    void Start()
    {
        debut = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - debut > 2.5)
        {
            Destroy(gameObject);
        }
    }
}
