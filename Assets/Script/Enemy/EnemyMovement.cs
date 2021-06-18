using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float enemySpeed;
    private GameObject playerObj;
    private bool canFollow;
    public Transform enemyParent;

    private void Start()
    {
        playerObj = GameObject.FindWithTag("Player");
    }

    private void FixedUpdate()
    {
        if(canFollow)
        {
            enemyParent.position = Vector3.Lerp(enemyParent.position,
                playerObj.transform.position, enemySpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canFollow = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canFollow = false;
        }
    }
}
