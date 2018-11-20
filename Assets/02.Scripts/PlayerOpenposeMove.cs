using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOpenposeMove : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 moveVector;

    private float speedLevel = 5.0f;
    private float jumpPower = 8.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;
    public int rightorLeft = 0; // -1 left 0 가만히 1 right 

    private Animator anim;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();

        anim.SetBool("isRun", true);
    }

    // Update is called once per frame
    void Update()
    {
        moveVector = Vector3.zero * speedLevel;

        if (controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        // X - Left and Right
        moveVector.x = rightorLeft * speedLevel;

        // Y - Up and Down
        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            anim.Play("FreeVoxelGirl-jump", -1, 0);
            verticalVelocity += Input.GetAxisRaw("Jump") * jumpPower;
        }

        moveVector.y = verticalVelocity;

        // Z - Forward and Backward
        moveVector.z = speedLevel;

        controller.Move(moveVector * Time.deltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
     
        if (hit.gameObject.tag != "Enemy")
            return;

        anim.Play("FreeVoxelGirl-damage", -1, 0);

    }
}
