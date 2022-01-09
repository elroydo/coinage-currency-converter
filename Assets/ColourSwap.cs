using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourSwap : MonoBehaviour {

    public Toggle backcolourToggle;
    public GameObject getBackground;
    public Color newColour, defaultColour;

    public void changeColour() {
        if (backcolourToggle.isOn)
        {
            getBackground.GetComponent<Image>().color = newColour;
        }
        else
        {
            getBackground.GetComponent<Image>().color = defaultColour;
        }
    }
}
