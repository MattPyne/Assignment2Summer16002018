using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformfall : MonoBehaviour
{
	
	
	void OnTriggerEnter(Collider col)
	{
		Debug.Log("Collision Function Entered");
		if (col.gameObject.tag == "Player")
		{
			Debug.Log("Collision function Entered");
			Invoke("FallDown", 0.6f);
		}
		
		     
	}
	private void FallDown()
	{
		this.GetComponentInParent<Rigidbody>().isKinematic = false;
		Destroy(this.transform.parent.gameObject, 2f);
	}

	
}
		
