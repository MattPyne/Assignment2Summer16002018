using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class GunObjects : ScriptableObject
{

	public float DamageLevel = 100;

	public float DoDamage()
	{
		return DamageLevel;
	}
}
