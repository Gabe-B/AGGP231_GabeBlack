using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowKeySpot : MonoBehaviour
{
	public bool collected = false;

	public int count = 0;

	private void OnTriggerEnter(Collider other)
	{
		YellowKey k = other.GetComponent<YellowKey>();

		if(k)
		{
			count++;
			Destroy(k);
		}
	}

	void Update()
	{
		if(count == 3)
		{
			collected = true;
		}
	}
}
