using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;

public class RoboArmMovement : MonoBehaviour
{

	private CharacterController _player;
	public Animator Anims;
	public float Speed = 50;
	public float JumpSpeed = 5;
	public float Gravity = -3f;
	private Vector3 position;
	
	// Use this for initialization
	void Start ()
	{
		_player = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

		position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;

		if (_player.isGrounded && Input.GetButton("Jump"))
		{
			position.y = JumpSpeed;
		}
		position.y += Gravity * Time.deltaTime;
		
		_player.Move(position);
		
		
		
		//Animation triggers
		if (Input.GetAxis("Horizontal") > 0)
			Anims.SetTrigger("MovementRight");
		if (Input.GetAxis("Horizontal") < 0)
			Anims.SetTrigger("MovementLeft");
		if (Input.GetAxis("Horizontal") == 0f)
			Anims.SetTrigger("NotMoving");
	}
}
