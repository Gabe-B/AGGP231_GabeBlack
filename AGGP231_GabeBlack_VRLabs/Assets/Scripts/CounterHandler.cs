using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterHandler : MonoBehaviour
{
    public List<TMP_Text> texts = new List<TMP_Text>();

    public Transform spawnPoint;

    public GameObject blueKey;

    public bool spawned = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(texts[0].text == "6" && texts[1].text == "3" && texts[2].text == "4" && !spawned)
		{
            Instantiate(blueKey, spawnPoint);
            spawned = true;
		}
    }
}
