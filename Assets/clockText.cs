using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class clockText : MonoBehaviour {

    public Text clockOutput;

	// Use this for initialization
	public void Start () {
        clockOutput.text = "Time : " + DateTime.Now.ToString("HH:mm:ss tt") +
        "\nDate : " + DateTime.Now.ToString("dd/MM/yyyy");

    }
}
