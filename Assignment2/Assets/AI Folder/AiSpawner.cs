using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiSpawner : MonoBehaviour
{

	public GameObject Ai;
	public Transform Destination;
	public Level CurrentLevel;
	private int aiCount;

	// Use this for initialization
	void Start ()
	{
		aiCount = CurrentLevel.AiCount;
		StartCoroutine(StartSpawn());
	}

	IEnumerator StartSpawn()
	{
		while (aiCount > 0)
		{
			GameObject newAI = Instantiate(Ai);
			
			newAI.GetComponent<AIMovement>().Destination = Destination;

			aiCount--;
			yield return new WaitForSeconds(CurrentLevel.Time);
		}
	}
}