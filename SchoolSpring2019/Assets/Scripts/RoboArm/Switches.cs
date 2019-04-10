using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

public class Switches : MonoBehaviour
{

	public UnityEvent StartingEvent, PlayingEvent, EndingEvent;
	
	public enum States
	{
		Starting, 
		Playing,
		Ending
	}

	public States CurrentState;
	
	// Update is called once per frame
	void Update () {
		switch (CurrentState)
		{
			case States.Starting:
				StartingEvent.Invoke();
				break;
			case States.Playing:
				PlayingEvent.Invoke();
				break;
			case States.Ending:
				EndingEvent.Invoke();
				break;
			default:
				throw new ArgumentOutOfRangeException();
		}
	}
}
