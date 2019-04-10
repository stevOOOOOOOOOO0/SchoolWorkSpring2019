using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class StateMachine : ScriptableObject
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
	public void OnSwitch () {
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
