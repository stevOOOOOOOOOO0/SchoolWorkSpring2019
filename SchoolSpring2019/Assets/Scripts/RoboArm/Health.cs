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

	private void Update()
	{
		Healths.UpdateValue(-1f * Time.deltaTime);
	}

	private void OnCollisionEnter(Collision other)
	{
		print("in it");
		if (other.gameObject.tag == "HealthBox")
		{
			Healths.UpdateValue(10f);
		}

		else
		{
			Healths.UpdateValue(-10f);
		}
	}
}