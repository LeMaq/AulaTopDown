using UnityEngine;

public abstract class AttackBehaviour : MonoBehaviour, IAttack
{
    public virtual void DoDamage(int damageAmount, GameObject target)
    {
        
    }
}
