using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class getInput : MonoBehaviour {
	
	public InputField userAmount, empID, empForename, empSurname, clientForename, clientSurname;
	public Dropdown currencyone, currencytwo;
	public Text output, reciept; 
	
	// Use this for initialization
	public void Setget () {

        //initialising float variables
        float amountInput = float.Parse(userAmount.text), amountPercentage = 0, amountWCCInput = 0, exchangeRate = 0, conversion = 0, roundedConversion;
        string symbolOne = "", symbolTwo = "";

        if (currencyone.value == 0) {
            symbolOne = "£";
        }
        else if (currencyone.value == 1) {
            symbolOne = "$";
        }
        else if (currencyone.value == 2) {
            symbolOne = "€";
        }
        else if (currencyone.value == 3)
        {
            symbolOne = "₹";
        }
        else if (currencyone.value == 4)
        {
            symbolOne = "¥";
        }

        if (currencytwo.value == 0)
        {
            symbolTwo = "£";
        }
        else if (currencytwo.value == 1)
        {
            symbolTwo = "$";
        }
        else if (currencytwo.value == 2)
        {
            symbolTwo = "€";
        }
        else if (currencytwo.value == 3)
        {
            symbolTwo = "₹";
        }
        else if (currencytwo.value == 4)
        {
            symbolTwo = "¥";
        }

        //if statements for selecting currencies

        //GBP - Pound Sterling
        //GBP, USD, EUR, INR, JPY
        //GBP>GBP = 1
        //GBP>USD = 1.385
        //GBP>EUR = 1.124
        //GBP>INR = 90.02
        //GBP>JPY = 147.97

        if (currencyone.value == 0 && currencytwo.value == 0)
        {
            exchangeRate = 1;
        }
        else if (currencyone.value == 0 && currencytwo.value == 1)
        {
            exchangeRate = 1.385f;
        }
        else if (currencyone.value == 0 && currencytwo.value == 2)
        {
            exchangeRate = 1.124f;
        }
        else if (currencyone.value == 0 && currencytwo.value == 3)
        {
            exchangeRate = 90.02f;
        }
        else if (currencyone.value == 0 && currencytwo.value == 4)
        {
            exchangeRate = 147.97f;
        }

        //USD - US Dollar
        //USD>GBP = 0.7218
        //USD>USD = 1
        //USD>EUR = 0.8119
        //USD>INR = 64.98
        //USD>JPY = 106.79

        if (currencyone.value == 1 && currencytwo.value == 0)
        {
            exchangeRate = 0.7218f;
        }
        else if (currencyone.value == 1 && currencytwo.value == 1)
        {
            exchangeRate = 1f;
        }
        else if (currencyone.value == 1 && currencytwo.value == 2)
        {
            exchangeRate = 0.8119f;
        }
        else if (currencyone.value == 1 && currencytwo.value == 3)
        {
            exchangeRate = 64.98f;
        }
        else if (currencyone.value == 1 && currencytwo.value == 4)
        {
            exchangeRate = 106.79f;
        }

        //EUR - Euro
        //EUR>GBP = 0.8889
        //EUR>USD = 1.231
        //EUR>EUR = 1
        //EUR>INR = 80.01
        //EUR>JPY = 131.53

        if (currencyone.value == 2 && currencytwo.value == 0)
        {
            exchangeRate = 0.8889f;
        }
        else if (currencyone.value == 2 && currencytwo.value == 1)
        {
            exchangeRate = 1.231f;
        }
        else if (currencyone.value == 2 && currencytwo.value == 2)
        {
            exchangeRate = 1;
        }
        else if (currencyone.value == 2 && currencytwo.value == 3)
        {
            exchangeRate = 80.01f;
        }
        else if (currencyone.value == 2 && currencytwo.value == 4)
        {
            exchangeRate = 131.53f;
        }

        //INR - Indian Rupee
        //INR>GBP = 0.01111
        //INR>USD = 0.01539
        //INR>EUR = 0.01249
        //INR>INR = 1
        //INR>JPY = 1.643

        if (currencyone.value == 3 && currencytwo.value == 0)
        {
            exchangeRate = 0.01111f;
        }
        else if (currencyone.value == 3 && currencytwo.value == 1)
        {
            exchangeRate = 0.01539f;
        }
        else if (currencyone.value == 3 && currencytwo.value == 2)
        {
            exchangeRate = 0.01249f;
        }
        else if (currencyone.value == 3 && currencytwo.value == 3)
        {
            exchangeRate = 1;
        }
        else if (currencyone.value == 3 && currencytwo.value == 4)
        {
            exchangeRate = 1.643f;
        }

        //JPY - Japanese yen
        //JPY>GBP = 0.006759
        //JPY>USD = 0.009363
        //JPY>EUR = 0.007602
        //JPY>INR = 0.6082
        //JPY>JPY = 1

        if (currencyone.value == 4 && currencytwo.value == 0)
        {
            exchangeRate = 0.006759f;
        }
        else if (currencyone.value == 4 && currencytwo.value == 1)
        {
            exchangeRate = 0.009363f;
        }
        else if (currencyone.value == 4 && currencytwo.value == 2)
        {
            exchangeRate = 0.007602f;
        }
        else if (currencyone.value == 4 && currencytwo.value == 3)
        {
            exchangeRate = 0.6082f;
        }
        else if (currencyone.value == 4 && currencytwo.value == 4)
        {
            exchangeRate = 1;
        }

        //conversion charge calculations

        if ((amountInput >=0) && (amountInput <= 99))
        {
            amountWCCInput = amountInput;
        }
        else if ((amountInput >= 100) && (amountInput <= 499))
        {
            amountPercentage = (amountInput / 100) * 1;
            amountWCCInput = amountInput - amountPercentage;
        }
        else if ((amountInput >= 500) && (amountInput <= 999))
        {
            amountPercentage = (amountInput / 100) * 2;
            amountWCCInput = amountInput - amountPercentage;
        }
        else if (amountInput >= 1000)
        {
            amountPercentage = (amountInput / 100) * 3;
            amountWCCInput = amountInput - amountPercentage;
        }

            //conversion calculation
            conversion = amountWCCInput * exchangeRate;

        //rounded to 2 decimal places and stored in the relevant variable
        roundedConversion = Mathf.Round(conversion *100f) / 100f;

        //output
        output.text = "Converted total = " + symbolOne + amountWCCInput + " * " + symbolTwo + exchangeRate + " = " + symbolTwo + roundedConversion;

        reciept.text = "Employee ID : " + empID.text + 
            "\nEmployee Name : " + empForename.text + " " + empSurname.text +
            "\nClient's Name : " + clientForename.text + " " + clientSurname.text +
            "\nConverted total = " + symbolTwo + roundedConversion + 
            "\n\nInitial amount entered = " + symbolOne + amountInput +
            "\nConversion charged = " + symbolOne + amountPercentage +
            "\nFinal amount = " + symbolOne + amountWCCInput +
            "\nConverted total w/ charges = " + symbolTwo + roundedConversion +
            "\n\nDate of completion : " + DateTime.Now.ToString("dd/MM/yyyy") + 
            "\nTime of completion : " + DateTime.Now.ToString("HH:mm:ss tt");
	}

}
