using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalScript : MonoBehaviour
{
    public GameObject numWinsText;
    public GameObject startPos;
    int wins = 0;

    private void OnTriggerEnter(Collider other)
    {
        JoystickPlayerExample pl = other.GetComponent<JoystickPlayerExample>();

        if(pl)
        {
            wins++;
            numWinsText.GetComponent<TMP_Text>().text = wins.ToString();
            pl.transform.position = startPos.transform.position;
            pl.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
