using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboArmMovement : MonoBehaviour
{

	private Rigidbody2D _player;
	public Animator Anims;
	public float Speed = 50;
	
	// Use this for initialization
	void Start ()
	{
		_player = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		_player.AddForce(_player.transform.right * Input.GetAxis("Horizontal") * Speed);
		if (Input.GetAxis("Horizontal") > 0)
			Anims.SetTrigger("MovementRight");
		if (Input.GetAxis("Horizontal") < 0)
			Anims.SetTrigger("MovementLeft");
		if (Input.GetAxis("Horizontal") == 0f)
		{
			Anims.SetTrigger("NotMoving");
			Anims.ResetTrigger("MovementLeft");
			Anims.ResetTrigger("MovementRight");
		}
	}
}
