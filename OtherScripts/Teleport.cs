using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	public GameObject player;
	public Transform spawnpoint;

	void Start()
	{
	}
	void OnTriggerEnter2D ( Collider2D other)
	{ 
		if (other.gameObject.tag == "Player")
		{
			player.transform.position = spawnpoint.transform.position;
			PublicVars.GateUP = false;
			PublicVars.ResetZombies = true;


		}
	}
}
