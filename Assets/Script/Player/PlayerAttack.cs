using System.Collections;
using UnityEngine;

public class PlayerAttack : AttackBehaviour
{
    [SerializeField] private bool canAttack;
    [SerializeField] private int damageAmount;
    public GameObject sword;
    public bool isAttacking;
    private Animator swordAnimator;
    private PlayerLife _playerLife;

    
    private static readonly int AttackTrigger = Animator.StringToHash("Attack");
    

    #region Animacao

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
        _playerLife = GetComponentInParent<PlayerLife>();
        canAttack = true;
        swordAnimator = gameObject.transform.GetChild(0).GetComponent<Animator>();
    }

    private void Attack()
    {
        if (canAttack)
        {
            DoDamage(damageAmount,sword);
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
    #endregion

    public override void DoDamage(int damageAmount, GameObject target)
    {
        
    }
}
