using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yamma : MonoBehaviour
{

	public GameObject Target;
	private bool TOOCLOSE = false;
	
	// Use this for initialization
	void Start () {
		Target = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Vector3.Distance(Target.transform.position, transform.position) < 20)
		{
			TOOCLOSE = true;
		}

		if (TOOCLOSE)
		{
			transform.position = Vector3.Lerp(transform.position, Target.transform.right * 100, .5f * Time.deltaTime);
			Destroy(gameObject, 3);
		}
	}
}
