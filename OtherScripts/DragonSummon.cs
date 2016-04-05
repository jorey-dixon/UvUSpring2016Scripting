using UnityEngine;
using System.Collections;

public class DragonSummon : MonoBehaviour {


	private int Roarlevel;

	public float speed = 1;


	// Use this for initialization
	void Start () {
		Audio3.OnPlayEnemyNoises += Soundplay;
	}

	public void Soundplay()
	{
		switch (Roarlevel) 
		{
		case 1: 
			Audio3.NoiseNumber = 11;
			Audio3.playme = true;
			break;
		case 2:
			Audio3.NoiseNumber = 12;
			Audio3.playme = true;
			break;
		case 3:
			Audio3.NoiseNumber = 13;
			Audio3.playme = true;
			PublicVars.moveDragon = true;
			break;
		default:
			break;
		}

	
		}
		
	// Update is called once per frame

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Player") {
			Roarlevel = Roarlevel + 1;
			Soundplay ();
		}
			
	}
}
