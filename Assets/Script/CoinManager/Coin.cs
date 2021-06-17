using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] 
    private CoinManager GameController;
    private BoxCollider2D BoxCol;
    private void Start()
    {
        BoxCol = GetComponent<BoxCollider2D>();
        GameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<CoinManager>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            GameController.addOneMoreCoin();
            Destroy(gameObject);
        }
    }
}
