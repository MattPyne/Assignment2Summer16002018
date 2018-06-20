using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{

	public WeaponObjects Weapon;
	public WeaponsCollection Collection;

	private void OnTriggerEnter(Collider onj)
	{
		Collection.CollectWeapon(Weapon);
	}
}
