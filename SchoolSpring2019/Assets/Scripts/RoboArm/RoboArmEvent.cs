using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoboArmEvent : MonoBehaviour
{

	public CharacterController RoboArm;
	public UnityEvent Event;
	public FloatData GoldCount;
	
	// Use this for initialization
	void Start ()
	{
		RoboArm = GetComponent<CharacterController>();
	}

	void OnCollisionEnter(Collision other)
	{
		Event.Invoke();
		print("in it");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
