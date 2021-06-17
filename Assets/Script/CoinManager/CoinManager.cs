using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    private int coin;
    [SerializeField]
    private TextMeshProUGUI tmpui;

    private void Start()
    {
        tmpui.text = "0X";
    }

    public void addOneMoreCoin()
    {
        coin++;
        tmpui.text = coin.ToString() + "X";
    }
    

}
