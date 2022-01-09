using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class getInput : MonoBehaviour {

    public InputField userAmount, empID, empForename, empSurname, clientForename, clientSurname; //the several input field objects are initialised as variables
    public Dropdown currencyone, currencytwo; //the several dropdown objects are initialised as variables
    public Text output, receiptHeadings, receipt; //the several text objects are initialised as variables

    //function
    public void Setget() {

        //initialising float variables
        float amountInput = float.Parse(userAmount.text), amountPercentage = 0, amountWCCInput = 0, exchangeRate = 0, conversion = 0, roundedConversion = 0;
        //initialising string variables
        string symbolOne = "", symbolTwo = "";

        if (userAmount.text == "0") //checks if the input for the amount field is 0
        {
            //if yes, output validation messages
            output.text = "Converted total w/ conversion charges applied will appear here. \nPlease enter an amount to convert.";
            receiptHeadings.text = "Please navigate back to the home page and complete the input fields.";
            receipt.text = "";
        }
        else {
            //if statement to determine the currency of the first dropdown box and store the symbol in the relevant variable
            if (currencyone.value == 0)
            {
                symbolOne = "£"; //currency symbol is stored in the relevant variable
            }
            else if (currencyone.value == 1)
            {
                symbolOne = "$"; //currency symbol is stored in the relevant variable
            }
            else if (currencyone.value == 2)
            {
                symbolOne = "€"; //currency symbol is stored in the relevant variable
            }
            else if (currencyone.value == 3)
            {
                symbolOne = "₹"; //currency symbol is stored in the relevant variable
            }
            else if (currencyone.value == 4)
            {
                symbolOne = "¥"; //currency symbol is stored in the relevant variable
            }

            //if statement to determine the currency of the second dropdown box and store the symbol in the relevant variable
            if (currencytwo.value == 0)
            {
                symbolTwo = "£"; //currency symbol is stored in the relevant variable
            }
            else if (currencytwo.value == 1)
            {
                symbolTwo = "$"; //currency symbol is stored in the relevant variable
            }
            else if (currencytwo.value == 2)
            {
                symbolTwo = "€"; //currency symbol is stored in the relevant variable
            }
            else if (currencytwo.value == 3)
            {
                symbolTwo = "₹"; //currency symbol is stored in the relevant variable
            }
            else if (currencytwo.value == 4)
            {
                symbolTwo = "¥"; //currency symbol is stored in the relevant variable
            }

            //if statements for selecting currencies

            //GBP - Pound Sterling
            //GBP, USD, EUR, INR, JPY
            //GBP>GBP = 1
            //GBP>USD = 1.385
            //GBP>EUR = 1.124
            //GBP>INR = 90.02
            //GBP>JPY = 147.97
            if (currencyone.value == 0 && currencytwo.value == 0) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 1; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 0 && currencytwo.value == 1) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 1.385f; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 0 && currencytwo.value == 2) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 1.124f; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 0 && currencytwo.value == 3) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 90.02f; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 0 && currencytwo.value == 4) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 147.97f; //exchange rate is stored in the relevant variable
            }

            //USD - US Dollar
            //USD>GBP = 0.7218
            //USD>USD = 1
            //USD>EUR = 0.8119
            //USD>INR = 64.98
            //USD>JPY = 106.79
            if (currencyone.value == 1 && currencytwo.value == 0) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 0.7218f; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 1 && currencytwo.value == 1) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 1f; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 1 && currencytwo.value == 2) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 0.8119f; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 1 && currencytwo.value == 3) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 64.98f; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 1 && currencytwo.value == 4) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 106.79f; //exchange rate is stored in the relevant variable
            }

            //EUR - Euro
            //EUR>GBP = 0.8889
            //EUR>USD = 1.231
            //EUR>EUR = 1
            //EUR>INR = 80.01
            //EUR>JPY = 131.53
            if (currencyone.value == 2 && currencytwo.value == 0) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 0.8889f; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 2 && currencytwo.value == 1) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 1.231f; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 2 && currencytwo.value == 2) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 1; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 2 && currencytwo.value == 3) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 80.01f; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 2 && currencytwo.value == 4) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 131.53f; //exchange rate is stored in the relevant variable
            }

            //INR - Indian Rupee
            //INR>GBP = 0.01111
            //INR>USD = 0.01539
            //INR>EUR = 0.01249
            //INR>INR = 1
            //INR>JPY = 1.643
            if (currencyone.value == 3 && currencytwo.value == 0) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 0.01111f;
            }
            else if (currencyone.value == 3 && currencytwo.value == 1) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 0.01539f; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 3 && currencytwo.value == 2) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 0.01249f; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 3 && currencytwo.value == 3) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 1; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 3 && currencytwo.value == 4) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 1.643f; //exchange rate is stored in the relevant variable
            }

            //JPY - Japanese yen
            //JPY>GBP = 0.006759
            //JPY>USD = 0.009363
            //JPY>EUR = 0.007602
            //JPY>INR = 0.6082
            //JPY>JPY = 1
            if (currencyone.value == 4 && currencytwo.value == 0) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 0.006759f; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 4 && currencytwo.value == 1) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 0.009363f; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 4 && currencytwo.value == 2) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 0.007602f; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 4 && currencytwo.value == 3) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 0.6082f; //exchange rate is stored in the relevant variable
            }
            else if (currencyone.value == 4 && currencytwo.value == 4) //identification of the chosen currencies from both dropdown menus
            {
                exchangeRate = 1; //exchange rate is stored in the relevant variable
            }

            //conversion charge calculations
            if ((amountInput >= 0) && (amountInput <= 99)) //checks to see if the input amount is between or equal to 0 and 99
            {
                amountWCCInput = amountInput; //input amount is assigned to the amount with conversion charges
            }
            else if ((amountInput >= 100) && (amountInput <= 499)) //checks to see if the input amount is between or equal to 100 and 499
            {
                amountPercentage = (amountInput / 100) * 1; //1% of the input amount is calculated and stored in the relevant variable
                amountWCCInput = amountInput - amountPercentage; //input amount is assigned to the amount with conversion charges
            }
            else if ((amountInput >= 500) && (amountInput <= 999)) //checks to see if the input amount is between or equal to 500 and 999
            {
                amountPercentage = (amountInput / 100) * 2; //2% of the input amount is calculated and stored in the relevant variable
                amountWCCInput = amountInput - amountPercentage; //input amount is assigned to the amount with conversion charges
            }
            else if (amountInput >= 1000) //checks to see if the input amount is more than 1000
            {
                amountPercentage = (amountInput / 100) * 3; //3% of the input amount is calculated and stored in the relevant variable
                amountWCCInput = amountInput - amountPercentage; //input amount is assigned to the amount with conversion charges
            }

            conversion = amountWCCInput * exchangeRate; //conversion calculation

            roundedConversion = Mathf.Round(conversion * 100f) / 100f; //rounded to 2 decimal places and stored in the relevant variable

            //output the converted total amount with conversion charges
            output.text = "Converted total = " + symbolOne + amountWCCInput + " * " + symbolTwo + exchangeRate + " = " + symbolTwo + roundedConversion;

            //checks to see if the order detail input fields are empty to print a receipt
            if ((empID.text == "") || (empForename.text == "") || (empSurname.text == "") || (clientForename.text == "") || (clientSurname.text == ""))
            {
                //if yes, output error message
                receiptHeadings.text = "Please navigate back to the home page and complete the input fields.";
                receipt.text = "";
            }
            else
            {
                //if not, output the receipt headings
                receiptHeadings.text = "Time of completion:" +
                "\nDate of completion:" +
                "\n\nEmployee ID:" +
                "\nEmployee Name:" +
                "\nClient's Name:" +
                "\n\nInitial amount entered =" +
                "\nConversion charged =" +
                "\nFinal conversion amount =" +
                "\nExchange rate =" +
                "\n\nConverted total w/ charges =";

                //if not, ouput the receipt
                receipt.text = DateTime.Now.ToString("HH:mm:ss tt") +
                "\n" + DateTime.Now.ToString("dd/MM/yyyy") +
                "\n\n" + empID.text +
                "\n" + empForename.text + " " + empSurname.text +
                "\n" + clientForename.text + " " + clientSurname.text +
                "\n\n" + symbolOne + amountInput +
                "\n" + symbolOne + amountPercentage +
                "\n" + symbolOne + amountWCCInput +
                "\n" + symbolTwo + exchangeRate +
                "\n\n" + symbolTwo + roundedConversion;
                
            }
        }
    }
}
