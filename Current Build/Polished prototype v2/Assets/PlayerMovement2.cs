using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{

    public PlayerController playerController;
    public Animator animPlayer;
    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal2") * runSpeed;
        animPlayer.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump2"))
        {
            jump = true;
        }

    }



    void FixedUpdate()
    {
        playerController.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }


}