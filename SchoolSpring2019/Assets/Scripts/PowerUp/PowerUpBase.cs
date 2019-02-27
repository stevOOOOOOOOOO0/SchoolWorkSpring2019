using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBase : MonoBehaviour
{

	public FloatData FData;

	private void OnCollisionEnter2D(Collision2D other)
	{
		Destroy(gameObject);
	}
}
