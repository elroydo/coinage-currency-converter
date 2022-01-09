using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FontColourToggle : MonoBehaviour {
    public Text empIDPlace, empIDText, empForePlace, empForeText, empSurPlace, empSurText, cliForePlace, cliForeText, cliSurPlace, cliSurText, amPlace, amText, dropOneText, dropTwoText, conText;
    public Toggle fontcolourToggle; //the toggle object is initialised as a variable
    public Text[] GetText; //the text object is initialised as a variable

    public void changeFontColour()
    {
        GetText = Text.FindObjectsOfType<Text>(); //grabs all the text componenets
        if (fontcolourToggle.isOn) //if toggle has been ticked/activated, execute code
        { //an array                                 
            foreach (Text go in GetText)                                                                                            
            { //loops through each text componenet                                
                go.color = Color.red; //sets the font colour to the new colour
            }

            empIDPlace.color = Color.magenta;
            empForePlace.color = Color.magenta;
            empSurPlace.color = Color.magenta;
            cliForePlace.color = Color.magenta;
            cliSurPlace.color = Color.magenta;
            amPlace.color = Color.magenta;
        }
        else
        {
            foreach (Text go in GetText)
            { //loops through each text componenet                                
                go.color = Color.white; //sets the font colour to the new colour
            }
            empIDPlace.color = Color.grey;
            empForePlace.color = Color.grey;
            empSurPlace.color = Color.grey;
            cliForePlace.color = Color.grey;
            cliSurPlace.color = Color.grey;
            amPlace.color = Color.grey;

            empIDText.color = Color.black;
            empForeText.color = Color.black;
            empSurText.color = Color.black;
            cliForeText.color = Color.black;
            cliSurText.color = Color.black;
            amText.color = Color.black;
            dropOneText.color = Color.black;
            dropTwoText.color = Color.black;
            conText.color = Color.black;
            
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name); //loads current scene, i.e. resets the application to revert the colour of text back to normal
        }
    }

}
