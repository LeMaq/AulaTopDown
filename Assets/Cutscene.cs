using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject[] dialog;
    private int conversationIndex;
    private bool dialogIsRunning = true;

    private void Start()
    {
        Debug.Log(dialog.Length);
        player.GetComponent<Player_Move>().enabled = false;
        player.transform.GetChild(0).GetComponent<PlayerAttack>().enabled = false;
            
    }

    private void Dialog()
    {
        if (conversationIndex < dialog.Length)
        {
            if (conversationIndex -1 >= 0)
            {
                dialog[conversationIndex -1].SetActive(false);
            }
            dialog[conversationIndex].SetActive(true);

            conversationIndex++;
        }
        else
        {
            dialog[conversationIndex -1].SetActive(false);
            player.GetComponent<Player_Move>().enabled = true;
            player.transform.GetChild(0).GetComponent<PlayerAttack>().enabled = true;
            dialogIsRunning = false;
        }

    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && dialogIsRunning)
        {
            Dialog();
        }
    }
}
