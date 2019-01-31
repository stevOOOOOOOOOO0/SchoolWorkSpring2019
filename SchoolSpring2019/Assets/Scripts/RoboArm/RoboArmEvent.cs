using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoboArmEvent : MonoBehaviour
{

	public UnityEvent Event;

	void OnCollisionEnter2D()
	{
		Event.Invoke();
	}
}
