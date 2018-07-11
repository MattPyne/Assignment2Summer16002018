using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu]
public class AIControll : ScriptableObject
{

	public float Speed;
	public float AngularsSpeed;

	public void ConfigAI(NavMeshAgent agent)
	{
		agent.speed = Speed;
		agent.angularSpeed = AngularsSpeed;
	}
	
}
