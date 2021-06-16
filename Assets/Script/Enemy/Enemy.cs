using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private PlayerAttack player;
    private BoxCollider2D BoxCol;

    private void Start()
    {
        BoxCol = GetComponent<BoxCollider2D>();
    }
}
