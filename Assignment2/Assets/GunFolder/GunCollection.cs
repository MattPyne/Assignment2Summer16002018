using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

[CreateAssetMenu]
public class GunCollection : ScriptableObject
{

	public List<GunObjects> Guns;

	public void CollectGun(GunObjects gun)
	{
		Guns.Add(gun);

		foreach (var item in Guns)
		{
			Debug.Log(item);

			if (item.name == "Nuke")
			{
				Debug.Log("NUKE 'EM!!!!!!!!");
			}
			else
				{
					Debug.Log("Get the Nuke!!");
				}
			
		}
		
	}
}
