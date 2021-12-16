using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueKeySpot : MonoBehaviour
{

	private void OnTriggerEnter(Collider other)
	{
		BlueKey k = other.GetComponent<BlueKey>();

	}
}
