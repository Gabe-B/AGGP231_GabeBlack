using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using TMPro;

public class Touch : MonoBehaviour
{
    //public Vector2 startPos;
    //public Vector2 direction;

    public int count = 0;
    public TMP_Text m_PlayerText;
    public TMP_Text randNumText;

    int randNum;
    bool endTouch = false;
    int range = 10;
	//string message;

	void Start()
	{
        randNum = Random.Range(100, 1000);
        randNumText.text = randNum.ToString();
	}

	// Update is called once per frame
	void Update()
    {
        //m_Text.text = "Touch: " + message + " in direction " + direction;

        if(Input.touchCount > 0)
		{
            UnityEngine.Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
				case TouchPhase.Began:
                    //startPos = touch.position;
                    //message = "Begun ";
                    if(endTouch == false)
					{
                        m_PlayerText.text = count.ToString();
                    }
                    break;

                case TouchPhase.Stationary:
                    //direction = touch.position - startPos;
                    //message = "Moving ";
                    if (endTouch == false)
                    {
                        m_PlayerText.text = count.ToString();
                        count++;
                    }
                    break;

                case TouchPhase.Ended:
                    //message = "Ending ";
                    endTouch = true;
                    CheckScore(randNum, count);
                    break;
            }
		}
    }

    void CheckScore(int goal, int count)
	{
        if((count <= (goal + range)) && (count >= (goal - range)))
		{
            randNumText.text = "Reached!";
		}
        else if(count >= (goal + range))
		{
            randNumText.text = "Overshot";
        }
        else if (count <= (goal - range))
        {
            randNumText.text = "Undershot";
        }
		else
		{
            randNumText.text = "PERFECT!!";
        }
    }
}
