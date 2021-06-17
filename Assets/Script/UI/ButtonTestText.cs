using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonTestText : MonoBehaviour
{
    private int counter;
    private TextMeshProUGUI tmp;

    private void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>();
    }

    public void ButtonTestClick()
    {
        Debug.Log("Funcionou");
        counter++;
        tmp.text = ("O número de vezes que o button foi clicado é : " + counter.ToString());
    }
}
