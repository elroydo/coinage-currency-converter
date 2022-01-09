using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FontColourToggle : MonoBehaviour {
    public Text empIDPlace, empIDText, empForePlace, empForeText, empSurPlace, empSurText, cliForePlace, cliForeText, cliSurPlace, cliSurText, amPlace, amText, dropOneText, dropTwoText, conText; //the text objects are initialised as a variable
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

            //colour is changed
            empIDPlace.color = Color.blue;
            empForePlace.color = Color.blue;
            empSurPlace.color = Color.blue;
            cliForePlace.color = Color.blue;
            cliSurPlace.color = Color.blue;
            amPlace.color = Color.blue;
        }
        else
        {
            foreach (Text go in GetText)
            { //loops through each text componenet                                
                go.color = Color.white; //sets the font colour to the new colour
            }

            //colour is changed
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
