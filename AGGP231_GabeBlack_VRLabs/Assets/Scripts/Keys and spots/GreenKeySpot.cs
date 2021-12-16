using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenKeySpot : MonoBehaviour
{

	private void OnTriggerEnter(Collider other)
	{
		GreenKey k = other.GetComponent<GreenKey>();

	}
}
