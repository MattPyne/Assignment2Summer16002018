using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemParticle : MonoBehaviour
{

	public void EndAnims()
	{
		GetComponent<MeshRenderer>().enabled = false;
		GetComponent<SphereCollider>().enabled = false;
		GetComponent<ParticleSystem>().Emit(20);
	}
}
