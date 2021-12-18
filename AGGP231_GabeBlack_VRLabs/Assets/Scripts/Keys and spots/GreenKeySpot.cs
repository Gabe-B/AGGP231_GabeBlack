using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenKeySpot : MonoBehaviour
{
	public int count = 0;
	public bool collected = false;

	private void OnTriggerEnter(Collider other)
	{
		GreenKey k = other.GetComponent<GreenKey>();

		if(k)
		{
			count++;
			Destroy(k);
		}
	}

	void Update()
	{
		if (count == 4)
		{
			collected = true;
		}
	}
}
