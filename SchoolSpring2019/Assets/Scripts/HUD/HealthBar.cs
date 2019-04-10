using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public FloatData HealthValue;
	private Image _health;
	
	// Use this for initialization
	void Start ()
	{
		_health = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		_health.fillAmount = HealthValue.Value / 100f;
	}
}
