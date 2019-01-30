using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoboArmEvent : MonoBehaviour
{

	public Rigidbody2D RoboArm;
	public UnityEvent Event;
	
	// Use this for initialization
	void Start ()
	{
		RoboArm = GetComponent<Rigidbody2D>();
	}

	void OncollisionEnter2D()
	{
		Event.Invoke();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
