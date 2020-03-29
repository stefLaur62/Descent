using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resumeGame : MonoBehaviour
{
    public GameObject pauseCanvas;

    public void resume()
    {
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
    }
}
