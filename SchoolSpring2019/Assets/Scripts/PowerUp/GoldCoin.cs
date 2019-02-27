using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEditor;
using UnityEngine;

public class GoldCoin : PowerUpBase
{
	[Range(0f, 0.5f)]
	public float Timer;
	public bool Up;
	public Vector3 StartingLocation;
	
	// Use this for initialization
	void Start ()
	{
		Timer = 0;
		StartingLocation = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = Vector3.Lerp(StartingLocation, StartingLocation + transform.up * 2, Timer);
		if (Up)
			Timer += 1 * Time.deltaTime;
		else 
			Timer -= 1 * Time.deltaTime;
		
		
		if (Timer >= .5)
			Up = false;
		else if (Timer <= 0)
			Up = true;
	}
}
