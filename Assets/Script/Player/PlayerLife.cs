using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : LifeBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private int lifeAmount;
    private void Start()
    {
        life = lifeAmount;
    }

    private void FixedUpdate()
    {
        slider.value = life;
    }
}
