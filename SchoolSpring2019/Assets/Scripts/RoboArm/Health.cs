using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

	public FloatData Healths;

	// Use this for initialization
	void Start ()
	{
		Healths.Value = 100;
	}
	
	// Update is called once per frame
	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "HealthBox")
		{
			Healths.Value += 10;
		}

		else
		{
			Healths.Value -= 10;
		}

		if (Healths.Value > 100)
		{
			Healths.Value = 100;
		}
		
		//print(Healths.Value);
	}
}