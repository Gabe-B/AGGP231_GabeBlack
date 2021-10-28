using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoor : MonoBehaviour
{
    public GameObject trapDoor;

	private void OnTriggerEnter(Collider other)
	{
		trapDoor.transform.rotation = Quaternion.Euler(90f, trapDoor.transform.rotation.y, trapDoor.transform.rotation.z);
	}
}
