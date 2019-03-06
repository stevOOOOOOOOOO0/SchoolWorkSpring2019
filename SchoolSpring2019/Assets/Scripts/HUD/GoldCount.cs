using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCount : MonoBehaviour
{

	public FloatData Gold;
	private Text goldOutput;

	// Use this for initialization
	void Start ()
	{
		Gold.Value = 0;
		goldOutput = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		goldOutput.text = Gold.Value.ToString();
	}
}
