using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiSpawner : MonoBehaviour
{

	public GameObject Ai;
	public Transform Destination;

	// Use this for initialization
	void Start ()
	{
		StartCoroutine(StartSpawn());
	}

	IEnumerator StartSpawn()
	{
		while (true)
		{
			GameObject newAI = Instantiate(Ai);
			
			newAI.GetComponent<AIMovement>().Destination = Destination;
			
			yield return new WaitForSeconds(2);
		}
	}
}