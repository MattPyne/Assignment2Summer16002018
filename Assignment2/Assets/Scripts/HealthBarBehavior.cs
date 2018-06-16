using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.UI;
using UnityEngine.XR.WSA;

public class HealthBarBehavior : MonoBehaviour
{

	public FloatData HealthLevel;
	public Image HealthImage;


	private void Start()
	{
		
		HealthImage.GetComponent<Image>().color = Color.green;
	}

	private void Update()
	{
		HealthImage.fillAmount = HealthLevel.Value;
		if (HealthLevel.Value < 0.66)
			HealthImage.GetComponent<Image>().color = Color.yellow;

		if (HealthLevel.Value < 0.33)
			HealthImage.GetComponent<Image>().color = Color.red;

		if (HealthLevel.Value <= 0)
		{
			Debug.Log("GAME OVER");
		}
	}
	
}
