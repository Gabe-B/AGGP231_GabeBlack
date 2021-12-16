using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleKeySpot : MonoBehaviour
{

	private void OnTriggerEnter(Collider other)
	{
		PurpleKey k = other.GetComponent<PurpleKey>();

		
	}
}
