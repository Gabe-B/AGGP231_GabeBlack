using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleKeyButtons : MonoBehaviour
{
    public GameObject arrow;
    public GameObject nextButton;

    public void SpawnArrow()
    {
        arrow.SetActive(true);
        nextButton.SetActive(true);
    }
}
