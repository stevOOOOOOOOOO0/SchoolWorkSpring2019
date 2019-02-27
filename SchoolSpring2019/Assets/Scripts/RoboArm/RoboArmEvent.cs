using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoboArmEvent : MonoBehaviour
{

	public Rigidbody2D RoboArm;
	public UnityEvent Event;
	public FloatData GoldCount;
	
	// Use this for initialization
	void Start ()
	{
		RoboArm = GetComponent<Rigidbody2D>();
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		Event.Invoke();
		if (other.gameObject.tag == "Gold")
			GoldCount.Value += 5;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
