using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public charactercontroller2D controller;
    public Animator animator;
    //private bool playingFootstep = false;
    //public float footstepSpeed = 1.0f;

    public float runSpeed = 40f;

    public float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    void Update () {
        
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        //StopFootsteps

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
        //StartFootsteps
    }

    public void OnLanding ()
    {
        animator.SetBool("IsJumping", false);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    //void StartFootsteps()
    //{
        //playingFootstep = true;
       //InvokeRepeating(nameof(PlayFootstep), 0f, footstepSpeed);
    //}

    //void StopFootsteps()
    //{
        //playingFootstep = false;
        //CancelInvoke(nameof(PlayFootstep));
    //}

    //void PlayFootstep()
    //{
        //SoundEffectManager.Play("Footstep");
    //}
}

