using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPlayerController : MonoBehaviour
{

	private Rigidbody rb;

	private bool isMovingRight = false;

	[SerializeField]
	private float speed = 4f;
	void Start ()
	{
		rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			ChangeBoolean();
			changeDirection();
		}
	}

	private void ChangeBoolean()
	{
		isMovingRight = !isMovingRight;
	}

	private void changeDirection()
	{
		if (isMovingRight)
		{
			rb.velocity = new Vector3(speed, 0f,0f);
		}
		else
		{
			rb.velocity = new Vector3(0f, 0f, speed);
		}
	}
}
