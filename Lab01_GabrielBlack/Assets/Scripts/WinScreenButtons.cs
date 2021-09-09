using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenButtons : MonoBehaviour
{
	public void QuitApp()
	{
		Time.timeScale = 1;
		Application.Quit();
	}

	public void ResetApp()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene("Example Scene");
	}
}
