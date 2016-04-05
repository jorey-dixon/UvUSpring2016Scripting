using UnityEngine;
using System.Collections;

public class AddForcesUpwards : MonoBehaviour {

	public Rigidbody2D Player;
	public bool OneTrigger = true;
	// Use this for initialization
	void Start () {
	
	}

	void Update()
	{
		//if (PublicVars.resetLaunchTrigger == true) {
		//	OneTrigger = true;
		//	PublicVars.resetLaunchTrigger = false;
		//}
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D col)
	{
		//if (OneTrigger == true) 
		//{
		//	OneTrigger = false;

			if (col.gameObject.tag == "Player") 
			{
				Player.AddForce (Vector2.up * 800);
				print ("boom");

			}
		}
	}
