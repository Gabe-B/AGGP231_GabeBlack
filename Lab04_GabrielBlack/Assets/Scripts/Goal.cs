using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
	public GameObject spawnPoint;

	[SerializeField]
	List<Key> keys = new List<Key>();

	[SerializeField]
	int numCollectedKeys = 0;

	void Start()
	{
		foreach(Key key in FindObjectsOfType<Key>())
		{
			keys.Add(key);
		}
	}

	void Update()
	{
		foreach(Key k in keys)
		{
			if(k.hasBeenCollected)
			{
				numCollectedKeys++;
			}
		}

		if(numCollectedKeys == keys.Count)
		{
			gameObject.GetComponent<Renderer>().enabled = true;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.TryGetComponent<Player>(out Player p))
		{
			p.transform.position = spawnPoint.transform.position;
			p.GetComponent<Rigidbody>().velocity = Vector3.zero;
		}
	}
}
