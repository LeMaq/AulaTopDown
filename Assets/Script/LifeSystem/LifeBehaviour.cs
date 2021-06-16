using UnityEngine;

public abstract class LifeBehaviour : MonoBehaviour, ILife
{
    protected int life;
    
    public void TakeDamage(int damageAmount)
    {
        if (damageAmount < life && life > 0)
        {
            life -= damageAmount;
        }
        else
        {
            Death();
        }
    }

    public void Death()
    {
        Debug.Log(gameObject.name + " Morreu!");
    }
}
