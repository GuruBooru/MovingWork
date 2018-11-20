using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour {

    public float speed = 3;
    public float jumpPower = 5f;

    Rigidbody rigdbody;

    Vector3 movement;
    float horizontalMove;
    float VerticalMove;
    bool isJumping;

	// Use this for initialization
	void Awake () {
        rigdbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        VerticalMove = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Jump"))
            isJumping = true;

	}
    void FixedUpdate()
    {
        Run();
        Jump();
    }
    void Run()
    {
        movement.Set(horizontalMove, 0, VerticalMove);
        movement = movement.normalized * speed * Time.deltaTime;

        rigdbody.MovePosition(transform.position + movement);
    }
    void Jump()
    {
        if (!isJumping)
            return;
        rigdbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        isJumping = false;
    }
}
