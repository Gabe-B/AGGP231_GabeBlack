using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
	public GameObject controlCanvas;
	public GameObject winCanvas;

	private void OnTriggerEnter(Collider other)
	{
		JoystickPlayerExample pl = other.GetComponent<JoystickPlayerExample>();

		if(pl)
		{
			controlCanvas.SetActive(false);
			winCanvas.SetActive(true);
			Time.timeScale = 0;
		}
	}
}
