using UnityEngine;

public class PlayerLife : LifeBehaviour
{
    [SerializeField] private int lifeAmount;
    private void Start()
    {
        life = lifeAmount;
    }
}
