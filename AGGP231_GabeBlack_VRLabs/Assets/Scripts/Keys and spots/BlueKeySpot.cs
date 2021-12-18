using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueKeySpot : MonoBehaviour
{
	public bool collected = false;

	private void OnTriggerEnter(Collider other)
	{
		BlueKey k = other.GetComponent<BlueKey>();

		if (k)
		{
			collected = true;
			Destroy(k);
		}
	}
}
