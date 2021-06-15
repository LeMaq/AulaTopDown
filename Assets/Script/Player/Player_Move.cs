using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class Player_Move : MonoBehaviour
{
    private float inputHorizontal;
    private float inputVertical;
    [SerializeField]
    private float speed;

    private Transform playerSprite;
    private Rigidbody2D rig;
    private BoxCollider2D boxCol;

    private void Start()
    {
        playerSprite = gameObject.transform.GetChild(0).GetComponent<Transform>();
        rig = GetComponent<Rigidbody2D>();
        boxCol = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

        if (inputHorizontal > 0.1)
        {
            playerSprite.eulerAngles =  new Vector3(0, 180, 0);
        }
        else if (inputHorizontal < -0.1)
        {
            playerSprite.eulerAngles =  new Vector3(0, 0, 0);
            
        }


        rig.velocity = new Vector2(
            inputHorizontal * speed * Time.deltaTime ,
            inputVertical * speed * Time.deltaTime
            );


    }
}
