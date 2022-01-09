using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourSwap : MonoBehaviour {

    public Toggle backcolourToggle; //the toggle object is initialised as a variable
    public GameObject getBackground; //the background object is initialised as a variable
    public Color newColour, defaultColour; //the several colour objects are initialised as variables

    public void changeColour() {
        if (backcolourToggle.isOn) //if toggle has been ticked/activated, execute code
        {
            getBackground.GetComponent<Image>().color = newColour; //changes the colour of the background to a new colour
        }
        else
        {
            getBackground.GetComponent<Image>().color = defaultColour; //returns the background to its default colour
        }
    }
}
