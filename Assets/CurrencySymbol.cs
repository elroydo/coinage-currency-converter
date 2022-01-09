using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencySymbol : MonoBehaviour {
    public Dropdown currencyone;
    public Text symbol;

    void Update() {
        if (currencyone.value == 0)
        {
            symbol.text = "£"; //currency symbol is stored in the relevant variable
        }
        else if (currencyone.value == 1)
        {
            symbol.text = "$"; //currency symbol is stored in the relevant variable
        }
        else if (currencyone.value == 2)
        {
            symbol.text = "€"; //currency symbol is stored in the relevant variable
        }
        else if (currencyone.value == 3)
        {
            symbol.text = "₹"; //currency symbol is stored in the relevant variable
        }
        else if (currencyone.value == 4)
        {
            symbol.text = "¥"; //currency symbol is stored in the relevant variable
        }
    }
}
