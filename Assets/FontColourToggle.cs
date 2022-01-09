using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FontColourToggle : MonoBehaviour {
    public Toggle fontcolourToggle;
    public Text[] GetText;

    public void changeFontColour()
    {
        GetText = Text.FindObjectsOfType<Text>(); //grabs all the text componenets
        if (fontcolourToggle.isOn)
        { //an array                                 
            foreach (Text go in GetText)                                                                                            
            { //loops through each text componenet                                
                go.color = Color.blue; //sets the font size to the newSize
            }                                        
        }
        else
        {
            foreach (Text go in GetText)
            { //loops through each text componenet
                go.color = Color.black; //sets the font size to the dafualtSize
            }
        }
    }

}
