using UnityEngine;

public class EnemyLife : LifeBehaviour
{
    [SerializeField] private int lifeAmount;
    private void Start()
    {
        life = lifeAmount;
    }
}
