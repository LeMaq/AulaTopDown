using System;
using UnityEngine;
using UnityEngine.UI;

public class EnemyLife : LifeBehaviour
{
    [SerializeField] private int lifeAmount;
    [SerializeField] private Slider slider;
    private void Start()
    {
        life = lifeAmount;
    }

    private void FixedUpdate()
    {
        slider.value = life;
    }
}
