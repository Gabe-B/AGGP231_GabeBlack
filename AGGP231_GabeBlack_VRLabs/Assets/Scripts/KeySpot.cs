using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpot : MonoBehaviour
{
	public GameObject door;

	private void OnTriggerEnter(Collider other)
	{
		Key k = other.GetComponent<Key>();

		if(k)
		{
			door.SetActive(false);
		}
	}
}
