using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace SampleNameSpace
{}

    
    public class SimpleScripts : MonoBehaviour
{
    private string MainUserName;
    private GUIStyle labelStyle;

    private void Start()
    {
        labelStyle = new GUIStyle();
        labelStyle.fontSize = 20;
        labelStyle.normal.textColor = Color.white;
    }

    public string userName
        {
            get { return MainUserName; } // Copy a value from a class, however the return function in this get statement returns the data to MainUserName
            // set { MainUserName = value; } // Edit this value
            set
            {
                var s = "";
            foreach (var c in value)
            {
                if (char.IsUpper(c))
                    s += char.ToLower(c);
                else if (char.IsLetter(c) || char.IsNumber(c))
                    s += c;
                else
                    Debug.LogError("bad username bro no special characters");
            }
            MainUserName = s;
        }
    }

        private void OnGUI()
        {
            GUI.Label(new Rect(500, 150, 100, 50), MainUserName, labelStyle);
        }
    }