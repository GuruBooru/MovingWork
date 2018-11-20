using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoving : MonoBehaviour {

    private CharacterController controller;
    private Vector3 moveVector;
	private Image heart1, heart2, heart3;
	private int heartcount = 3;
	private bool isDamaged = false;

    private float speedLevel = 5.0f;
    private float jumpPower = 8.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;

    private Animator anim;

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
		heart1 = GameObject.Find ("heart1").GetComponent<Image>();
		heart2 = GameObject.Find ("heart2").GetComponent<Image>();
		heart3 = GameObject.Find ("heart3").GetComponent<Image>();

        anim.SetBool("isRun", true);
	}
	
	// Update is called once per frame
	void Update () {
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
        moveVector.x = Input.GetAxisRaw("Horizontal") * speedLevel;

        // Y - Up and Down
        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            anim.Play("FreeVoxelGirl-jump", -1, 0);
            verticalVelocity += Input.GetAxisRaw("Jump") * jumpPower;
        }
          
        moveVector.y = verticalVelocity;

        // Z - Forward and Backward
        moveVector.z = speedLevel;

        // Goal
        if (GoalArea.goal || Out.isOut)
            moveVector = Vector3.zero;
        controller.Move(moveVector * Time.deltaTime);
	}

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //Rigidbody body = hit.collider.attachedRigidbody;

        //if (body == null || body.isKinematic)
        //    return;

        if (hit.gameObject.tag != "Enemy")
            return;

        anim.Play("FreeVoxelGirl-damage", -1, 0);

/*		heartcount--;
		isDamaged = true;
		StartCoroutine ("UnDamageTime");
		Debug.Log ("heart--");
		//Invoke ("OnControllerColliderHit", 2);
		if (heartcount == 2 && !isDamaged)
		{
			Debug.Log ("heart2");
			Destroy (heart1);
			//heart1.material.color = Color.white;
		}
		if (heartcount == 1 && !isDamaged)
		{
			heart2.material.color = Color.gray;
//			isDamaged = true;
//			StartCoroutine ("UnDamageTime");
		}
		if (heartcount == 0 && !isDamaged)
		{
			heart3.material.color = Color.gray;
			Time.timeScale = 0;
			Application.LoadLevel("GameOver");
		}
*/
        //anim.SetBool("isDamage", false);
    }

	IEnumerator UnDamageTime(){
		Debug.Log ("delay1");
		int countTime = 0;
		while (countTime < 5) {
			yield return new WaitForSeconds (0.1f);
			countTime++;
			Debug.Log ("delay2");
		}
		isDamaged = false;
		yield return null;
	}
}
