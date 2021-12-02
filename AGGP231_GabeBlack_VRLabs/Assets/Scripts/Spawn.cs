using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject keyPrefab;
    public Transform spawnPoint;

    public void SpawnKey()
	{
        Instantiate(keyPrefab, spawnPoint);
	}
}
