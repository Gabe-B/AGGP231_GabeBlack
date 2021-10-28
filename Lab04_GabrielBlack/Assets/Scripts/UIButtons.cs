using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR;
using UnityEngine.XR.ARFoundation;

public class UIButtons : MonoBehaviour
{
    public ARPlaneManager pm;

    public void ARPause()
    {
        pm.enabled = false;
    }

    public void ARResume()
    {
        pm.enabled = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
