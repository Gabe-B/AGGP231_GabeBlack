using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleKeySpot : MonoBehaviour
{
	public bool collected = false;

	private void OnTriggerEnter(Collider other)
	{
		PurpleKey k = other.GetComponent<PurpleKey>();

		if (k)
		{
			collected = true;
			Destroy(k);
		}
	}
}
