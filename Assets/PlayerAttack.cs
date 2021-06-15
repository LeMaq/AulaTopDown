using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public bool isAttacking;
    [SerializeField] 
    private bool canAttack;
    private Animator swordAnimator;
    private static readonly int AttackTrigger = Animator.StringToHash("Attack");

    public void StartAttack()
    {
        isAttacking = true;
    }

    public void EndAttack()
    {
        isAttacking = false;
    }
    
    private void Start()
    {
        canAttack = true;
        swordAnimator = gameObject.transform.GetChild(0).GetComponent<Animator>();
    }

    private void Attack()
    {
        if (canAttack)
        {
            swordAnimator.SetTrigger(AttackTrigger);
            StartCoroutine(AttackDelay(2.0f));
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
    }

    private IEnumerator AttackDelay(float tempoDeEspera)
    {
        canAttack = false;
        yield return new WaitForSeconds(tempoDeEspera);
        canAttack = true;
    }
}
