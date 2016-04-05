using UnityEngine;
using System.Collections;

public class PassGate : MonoBehaviour {

	void Start()
	{
		//this.GetComponent<BoxCollider2D> ().enabled = false;
		PublicVars.GateUP = false;
	}

	void OnTriggerEnter2D ( Collider2D other)
	{ 
		//this.GetComponent<BoxCollider2D> ().enabled = false;

		if (other.gameObject.tag == "Player") {

			if (PublicVars.GateUP == true) {

				this.GetComponent<BoxCollider2D> ().enabled = true;

			} else if (PublicVars.GateUP == false)

				this.GetComponent<BoxCollider2D> ().enabled = false;
		}
	}




	// Use this for initialization
	void OnTriggerExit2D ( Collider2D other)
	{ 
		if (other.gameObject.tag == "Player") 
			{
			if (PublicVars.GateUP == false) 
				{
					this.GetComponent<BoxCollider2D> ().enabled = true;
					PublicVars.GateUP = true;
				}
			}
	}



}

