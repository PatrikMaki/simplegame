using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneController : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    // Start is called before the first frame update
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    //touchscreen



    // Update is called once per frame
    void Update()
    {
        //horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        //touchscreenversion
        horizontalMove = Input.acceleration.x * runSpeed;

        animator.SetFloat("speed", Mathf.Abs(horizontalMove));

        //touch
        if (Input.touchCount > 0)
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        /*
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
        //*/
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
