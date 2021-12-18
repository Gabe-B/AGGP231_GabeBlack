using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlateHandler : MonoBehaviour
{
    public int count;

    public GameObject redKey;

    public Transform spawnPoint;

    bool spawned = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(count == 3 && !spawned)
		{
            Instantiate(redKey, spawnPoint);
            spawned = true;
		}
    }
}
