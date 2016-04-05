using UnityEngine;
using System.Collections;

public class SpecAttackBumper : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Player_Ball" && this.gameObject.name == "SpecAttackBumper") 
		{

			PublicVars.score += 100;
			PublicVars.specialAttackCounter ++;
		
		}
	switch(PublicVars.specialAttackCounter)
		{
		case 1 :
			this.GetComponent<SpriteRenderer>().color = Color.green;
			break;
		case 2:
			this.GetComponent<SpriteRenderer>().color = Color.yellow;
			break;
		case 3:
			this.GetComponent<SpriteRenderer>().color = Color.red;
			PublicVars.specialAttackCounter = 0;
			break;
		default:
			Debug.Log ("SpecAttackBumpSwitch Default");
			break;
		}
	}
}
