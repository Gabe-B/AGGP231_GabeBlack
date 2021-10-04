using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR;
using UnityEngine.XR.ARFoundation;

public class UIButtons : MonoBehaviour
{

    public ARSession arsession;

    public void ARPause()
    {
        arsession.enabled = false;
    }
    public void ARResume()
    {
        arsession.enabled = true;
    }
}
