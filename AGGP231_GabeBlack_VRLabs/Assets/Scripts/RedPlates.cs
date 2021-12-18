using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlates : MonoBehaviour
{
	public RedPlateHandler rp;

	private void OnTriggerEnter(Collider other)
	{
		Player p = other.GetComponent<Player>();

		if(p)
		{
			rp.count++;
			gameObject.SetActive(false);
		}
	}
}
