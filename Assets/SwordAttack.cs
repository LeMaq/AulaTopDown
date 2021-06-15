using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    private PlayerAttack player;

    private void Start()
    {
        player = transform.parent.gameObject.GetComponent<PlayerAttack>();
    }

    public void SA()
    {
        player.StartAttack();
    }

    public void EA()
    {
        player.EndAttack();
    }
}
