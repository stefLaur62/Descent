using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipEnd : MonoBehaviour
{
    public GameObject endCanvas;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {

            endCanvas.SetActive(true);
            Time.timeScale = 0;

        }
    }
}
