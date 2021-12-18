using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterButtons : MonoBehaviour
{
    public TMP_Text numCounter;

    int currNum = 0;

    public void CounterPressed()
	{
        if(currNum == 9)
		{
			currNum = 0;
			numCounter.text = currNum.ToString();
		}
		else
		{
			currNum++;
			numCounter.text = currNum.ToString();
		}
	}
}
