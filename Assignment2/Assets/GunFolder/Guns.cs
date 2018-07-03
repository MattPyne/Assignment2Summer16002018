using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : MonoBehaviour {

	public enum GunType
	{
		Ak47,
		Shotgun,
		FiftyCal,
		MuzzleLoader,
		SawnOffShotgun,
		Nuke,
	}

	public GunObjects[] GunObjectses;

	public GunType CurrentGun;

	private void Update()
	{
		switch (CurrentGun)
		{
				case GunType.Ak47:
					Debug.Log(GunObjectses[0].name);
					Debug.Log(GunObjectses[0].DoDamage());
					break;
				
			case GunType.Shotgun:
				Debug.Log(GunObjectses[1].name);
				Debug.Log(GunObjectses[1].DoDamage());
				break;
			
			case GunType.FiftyCal:
				Debug.Log(GunObjectses[2].name);
				Debug.Log(GunObjectses[2].DoDamage());
				break;
			
			case GunType.MuzzleLoader:
				Debug.Log(GunObjectses[3].name);
				Debug.Log(GunObjectses[3].DoDamage());
				break;
			
			case GunType.SawnOffShotgun:
				Debug.Log(GunObjectses[4].name);
				Debug.Log(GunObjectses[4].DoDamage());
				break;
			
			case GunType.Nuke:
				Debug.Log(GunObjectses[5].name);
				Debug.Log(GunObjectses[5].DoDamage());
				break;
		}
	}
}
