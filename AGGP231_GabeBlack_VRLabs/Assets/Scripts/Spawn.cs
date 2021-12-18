using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject keyPrefab;
    public Transform spawnPoint;

    bool spawned = false;

    public void SpawnKey()
	{
        if(!spawned)
		{
            Instantiate(keyPrefab, spawnPoint);
            spawned = true;
        }
	}
}
