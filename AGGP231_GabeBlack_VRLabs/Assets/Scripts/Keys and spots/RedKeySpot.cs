using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedKeySpot : MonoBehaviour
{
	public bool collected = false;

	private void OnTriggerEnter(Collider other)
	{
		RedKey k = other.GetComponent<RedKey>();

		if (k)
		{
			collected = true;
		}
	}
}
