using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour {

	public enum WeaponType
	{
		Axe,
		Club,
		Sword,
		Spear,
		Scimitar,
		
	}

	public WeaponObjects[] WeaponObjectses;

	public WeaponType CurrentWeapon;

	void Update()
	{
		switch (CurrentWeapon)
		{
				case WeaponType.Axe:
					Debug.Log(WeaponObjectses[0].name);
					Debug.Log(WeaponObjectses[0].DoDamage());
					break;
				
				case WeaponType.Club:
					Debug.Log(WeaponObjectses[1].name);
					Debug.Log(WeaponObjectses[1].DoDamage());
					break;
				
				case WeaponType.Scimitar:
					Debug.Log(WeaponObjectses[2].name);
					Debug.Log(WeaponObjectses[2].DoDamage());
					break;
				
				case WeaponType.Spear:
					Debug.Log(WeaponObjectses[3].name);
					Debug.Log(WeaponObjectses[3].DoDamage());
					break;
				
				case WeaponType.Sword:
					Debug.Log(WeaponObjectses[4].name);
					Debug.Log(WeaponObjectses[4].DoDamage());
					break;
		}
	}
}
