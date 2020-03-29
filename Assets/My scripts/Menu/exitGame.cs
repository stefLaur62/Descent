using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class exitGame : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("quit");
        EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
