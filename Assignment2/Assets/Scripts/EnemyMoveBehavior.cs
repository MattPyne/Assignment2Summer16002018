using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveBehavior : MonoBehaviour {

	public Transform[] Target;
	public float Speed;

	private int current;

	
	// Update is called once per frame
	void Update ()
	{
		if (transform.position != Target[current].position)
		{
			Vector3 pos = Vector3.MoveTowards(transform.position, Target[current].position, Speed * Time.deltaTime);
			GetComponent<Rigidbody>().MovePosition(pos);
		}
		else current = (current + 1) % Target.Length;
	}
}
