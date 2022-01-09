using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FontSizeToggle : MonoBehaviour {
    public Toggle fontsizeToggle;
    public Text[] GetText;

    public int newSize, defaultSize;

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
