using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MoveSingleJump : MoveBase {
	public override void Move(CharacterController controller)
	{
		position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
		
		if (controller.isGrounded && Input.GetButton("Jump"))
		{
			position.y = JumpSpeed;
		}
		position.y += Gravity * Time.deltaTime;
		
		controller.Move(position);
	}
}
