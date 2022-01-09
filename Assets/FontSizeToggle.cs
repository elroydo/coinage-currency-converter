using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FontSizeToggle : MonoBehaviour {
    public Toggle fontsizeToggle; //the toggle object is initialised as a variable
    public Text[] GetText; //the text objects is initialised as a variable

    const int defaultSize = 14; //integer variable is initialised for the default font size
    public int newSize; //integer variable is initialised for the new font size

    public void changeFontSize() {
        GetText = Text.FindObjectsOfType<Text>(); //grabs all the text componenets
        if (fontsizeToggle.isOn) { //an array
            foreach (Text go in GetText) { //loops through each text componenet
                go.fontSize = newSize; //sets the font size to the newSize
            }
        }
        else {
            foreach (Text go in GetText) { //loops through each text componenet
                go.fontSize = defaultSize; //sets the font size to the dafualtSize
            }
        }
    }
}
