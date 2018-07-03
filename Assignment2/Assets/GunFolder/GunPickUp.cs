using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickUp : MonoBehaviour {
	
	public GunObjects Gun;
	public GunCollection Collection;

	private void OnTriggerEnter(Collider onj)
	{
		Collection.CollectGun(Gun);
	}
}
