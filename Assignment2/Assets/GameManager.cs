﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	private float size;

	[SerializeField] 
	GameObject Platform;

	private Vector3 lastPos;
	
	void Start ()
	{
		size = Platform.transform.localScale.x;
		lastPos = Platform.transform.position;
		for (int x = 0; x < 24; x++)
		{
			SpawnZ();
		}
		InvokeRepeating("spawnPlatform", 2f, 0.2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void spawnPlatform()
	{
		int random = Random.Range(0, 6);
		if (random <3)
			SpawnX();
		
		if (random >= 3)
			SpawnZ();
	}

	private void SpawnX()
	{
		GameObject platform = Instantiate(Platform) as GameObject;
		platform.transform.position = lastPos + new Vector3(size, 0f, 0f);
		lastPos = platform.transform.position;
	}

	private void SpawnZ()
	{
		GameObject platform = Instantiate(Platform) as GameObject;
		platform.transform.position = lastPos + new Vector3(0f, 0f, size);
		lastPos = platform.transform.position;
	}
}
