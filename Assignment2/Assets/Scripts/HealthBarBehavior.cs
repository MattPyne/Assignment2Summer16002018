using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
		if (HealthLevel.Value < 0.5)
			HealthImage.GetComponent<Image>() = Color.yellow;

		if (HealthImage.Value < 0.33)
			HealthImage.GetComponent<Image>() = Color.red;

	}
}
