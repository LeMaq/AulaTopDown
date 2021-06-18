using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    private PlayerAttack player;
    private GameObject target;
    public int swordDamage;
    private bool alreadyAttack;

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
        alreadyAttack = false;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") && player.isAttacking && !alreadyAttack)
        {
            target = other.gameObject;
            target.GetComponent<EnemyLife>().TakeDamage(swordDamage);
            alreadyAttack = true;
        }
    }
}
