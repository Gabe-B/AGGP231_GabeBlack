using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
	public bool hasBeenCollected = false;

	private void OnTriggerEnter(Collider other)
	{
		if(other.TryGetComponent<Player>(out Player p) && !hasBeenCollected)
		{
			gameObject.GetComponent<Renderer>().enabled = false;
		}
	}
}
