using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : LifeBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private int lifeAmount;
    private void Awake()
    {
        life = lifeAmount;
    }

    private void FixedUpdate()
    {
        slider.value = life;
    }

    public override void Death()
    {
        life = 0;
        gameObject.SetActive(false);
    }
}
