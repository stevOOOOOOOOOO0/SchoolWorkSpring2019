using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class GoldCoin : PowerUpBase
{

	public float BounceTime = 1;
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
		Timer += 1 * Time.deltaTime;
		if (Up)
			transform.position = Vector3.Lerp(StartingLocation, StartingLocation + transform.up * 2, Timer);
		else
			transform.position = Vector3.Lerp(StartingLocation + transform.up * 2, StartingLocation, Timer);

		if (Timer >= 1)
		{
			Timer = 0;
		}
	}
}
