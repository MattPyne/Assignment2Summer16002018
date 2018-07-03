using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class Ammo : MonoBehaviour
{

	private Rigidbody projectile;
	public FloatData ProjectileSpeed;
	public FloatData ProjectileUpgrade;
	private Vector3 startPos;
	
	private void OnEnable()
	{
		projectile = GetComponent<Rigidbody>();
		projectile.AddForce(0,0,ProjectileSpeed.Value);
		Invoke("Deactivate", 1);
	
	}

	private void Deactivate()
	{
		gameObject.SetActive(false);
		transform.position = startPos;
	}

	private void OnTriggerEnter(Collider other)
	{
		ProjectileSpeed = ProjectileUpgrade;
		projectile.AddForce(0,0,ProjectileSpeed.Value);
	}

	
}
