using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private int damageAmount;
    private float timer;
    private bool canAttack;
    [SerializeField] private float attackDelay;


    private void Update()
    {
        if (timer >= attackDelay && !canAttack)
        {
            canAttack = true;
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && canAttack)
        {
            other.gameObject.GetComponent<PlayerLife>().TakeDamage(damageAmount);
            canAttack = false;
        }
    }
}
