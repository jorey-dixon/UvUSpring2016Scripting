using UnityEngine;
using System.Collections;

public class DestructibleGate : MonoBehaviour {

	public int Health = 10;


	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Player_Ball" && this.gameObject.name == "LeftGate") {
			PublicVars.leftGateHp--;

		} else if (coll.gameObject.name == "Player_Ball" && this.gameObject.name == "ReftGate") {
			PublicVars.rightGateHp--;
		} else 
		{
			Health--;
		}

		if ((PublicVars.rightGateHp == 0) && (this.gameObject.name == "LightGate")) 
		{
			Destroy (this.gameObject);
		}
		else if ((PublicVars.rightGateHp == 0) && (this.gameObject.name == "RightGate")) 
		{
			Destroy (this.gameObject);
		} 
		else if (Health == 0) 
		{
			Destroy (this.gameObject);
		}


	}

}
