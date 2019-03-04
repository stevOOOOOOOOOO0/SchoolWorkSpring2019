using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveBase : ScriptableObject
{
	protected Vector3 position;
	public float Gravity = -9.81f;
	public float JumpSpeed = 20;
	public float Speed = 50;

	public abstract void Move(CharacterController controller);

}
