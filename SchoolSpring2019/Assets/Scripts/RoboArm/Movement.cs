using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	private CharacterController _armPot
	private float _translation = 0f;
	private float _verticle = 0f;
	private float _translationSpeed = 10f;
	private Vector3 _moveDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        _armPot = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
	if (Input.GetButtonDown("Space"))
	{
		_verticle = 10f;
	}
	_moveDirection = new Vector3(Input.GetAxis("Horizontal") * _translationSpeed, _vertical, 0.0f);
	_armpot.Move(_moveDirection * Time.deltaTime);
    }
}
