using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class clockText : MonoBehaviour {

    public Text clockOutput;

    // Use this for initialization
    void Start () {
  
    }

    void Update ()
    {
        clockOutput.text = DateTime.Now.ToString("HH:mm:ss tt") +
        "\n" + DateTime.Now.ToString("dd/MM/yyyy");
    }
}