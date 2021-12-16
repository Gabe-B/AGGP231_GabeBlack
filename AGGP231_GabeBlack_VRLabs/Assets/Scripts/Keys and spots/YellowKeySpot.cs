using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowKeySpot : MonoBehaviour
{

	private void OnTriggerEnter(Collider other)
	{
		YellowKey k = other.GetComponent<YellowKey>();

	}
}
