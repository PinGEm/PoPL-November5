using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private SimpleScripts simpleScript;
    private string newUsername;
    public Texture2D btnImage;

    private void Start()
    {
        simpleScript = GetComponent<SimpleScripts>();
    }

    private void OnGUI()
    {
        newUsername = GUI.TextField(new Rect(50, 200, 200, 30), newUsername);

        if (GUI.Button(new Rect(10, 10, 300, 150), btnImage))
        {
            simpleScript.userName = newUsername;
        }
    }
}
