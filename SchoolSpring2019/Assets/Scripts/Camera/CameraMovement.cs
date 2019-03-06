using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

	public Transform Player;
	private Vector3 _newPosition;
	
	// Use this for initialization
	void Start ()
	{
		Player.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		_newPosition = Player.position - Player.forward * 35;
		//Transform.
		
	}
}
