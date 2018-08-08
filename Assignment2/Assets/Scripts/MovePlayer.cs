﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	public IntData CoinCollection;
	private CharacterController controller;
	private Vector3 newPosition;

	public float Speed = 10.0f;
	public float Gravity = 9.81f;
	public float JumpSpeed = 10.0f;

	public bool CanRun = true;
	

	// Use this for initialization
	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
		{
			newPosition.y = JumpSpeed;
		}

		
		newPosition.y -= Gravity;
		if (CanRun)
		{
			newPosition.z = Speed*Input.GetAxis("Vertical");
			newPosition.x = Speed * Input.GetAxis("Horizontal");
			
		}
		controller.Move(newPosition * Time.deltaTime);
	}

	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Gems")
		{
			Destroy(col.gameObject);
			CoinCollection.Value++;

		}
	}
}
