using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement; 

public class restartGame : MonoBehaviour
{
    public void RestartGame()
    {
        Debug.Log("restart");
        Time.timeScale = 1;
        SceneManager.LoadScene("My_world");
    }
}
