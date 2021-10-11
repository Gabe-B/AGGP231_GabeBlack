using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR;
using UnityEngine.XR.ARFoundation;

public class UIButtons : MonoBehaviour
{

    public ARPlaneManager arPlaneManager;

    public void ARPause()
    {
        arPlaneManager.enabled = false;
    }
    public void ARResume()
    {
        arPlaneManager.enabled = true;
    }
}
