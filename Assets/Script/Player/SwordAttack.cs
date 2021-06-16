using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    private PlayerAttack player;
    public GameObject target;

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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            target = other.gameObject;
        }
    }
}
