using System.Collections;
using System.Collections.Generic;
using System; //syste directive
using UnityEngine;
using UnityEngine.UI;

public class clockText : MonoBehaviour {

    public Text dateText, timeText; //the several text objects are initialised as variables

    void Update () //this function allows use to output the date and time, live
    {
        dateText.text = DateTime.Now.ToString("HH:mm:ss tt"); //the system date is fetched and stored in the text object that outputs the date
        timeText.text = DateTime.Now.ToString("dd/MM/yyyy"); //the system time is fetched and stored in the text object that outputs the time
    }
}