using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    
    float speed;
    public float walkingSpeed = 8f;
    public float sprintSpeed = 12f;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        //ground check
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        
        if(controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        //movement
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //sprint
        if(controller.isGrounded) 
        {
            if (Input.GetKey(KeyCode.LeftShift) && z == 1)
            {
                speed = sprintSpeed;
            }
            else
            {
                speed = walkingSpeed;    
            }
        }
        else
        {
            speed = walkingSpeed;
        }
       
        //movement
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown)
        // gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
