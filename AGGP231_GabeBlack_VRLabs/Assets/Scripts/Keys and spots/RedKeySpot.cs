using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedKeySpot : MonoBehaviour
{

	private void OnTriggerEnter(Collider other)
	{
		RedKey k = other.GetComponent<RedKey>();


	}
}
