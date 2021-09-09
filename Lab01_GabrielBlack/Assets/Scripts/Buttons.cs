using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void QuitApp()
	{
		Time.timeScale = 1;
		Application.Quit();
	}

	public void ResetApp()
	{
		Time.timeScale = 1;
		string scene = SceneManager.GetActiveScene().name;
		SceneManager.LoadScene(scene);
	}

	public void SwapAppToApp1()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene(0);
	}

	public void SwapAppToApp2()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene(1);
	}
}
