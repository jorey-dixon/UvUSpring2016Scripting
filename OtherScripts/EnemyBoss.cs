using UnityEngine;
using System.Collections;

public class EnemyBoss : MonoBehaviour {

	private int HP = 10;

	private bool dead;

	public GameObject Skele1;
	public GameObject Skele2;
	public GameObject Skele3;


	void Start()
	{
		Audio3.OnPlayEnemyNoises += playSound;
	}

	void OnTriggerEnter2D (Collider2D col)
	{

		if(col.gameObject.name == "CannonBall"||col.gameObject.name == "CannonBall (Clone)")
		{
			PublicVars.EnemyHP = PublicVars.EnemyHP-2;
			print("playing sounds");
			Destroy(col.gameObject);
			playSound();
			print (HP);

		}
		if(col.gameObject.tag == "Cannon")
		{
			PublicVars.EnemyHP = PublicVars.EnemyHP-2;
			print("playing sounds");
			Destroy(col.gameObject);
			playSound();
			print (HP);
			
		}
		Debug.Log ("working");


	}

	void Update()
	{
		if (PublicVars.EnemyHP == 0) {

			dead = true;

			playSound ();
			StartCoroutine(YouWin());
			if(PublicVars.skeletonSummon == true)
			{
			PublicVars.skeletonSummon = false;
			StartCoroutine(Summon());
			}
		} 
		
	}

	void playSound()
	{
		if (dead == true) {
			Audio3.NoiseNumber = 9;
			Audio3.playme = true;
		}
		else 
		{
			//Audio3.NoiseNumber = 10;
			Audio3.playme = true;

			
		}
	}

	IEnumerator YouWin()
	{
		yield return new WaitForSeconds (2.5f);

		Application.LoadLevel (5);
	}

	IEnumerator Summon()
	{
		yield return new WaitForSeconds (15f);




		//Summon Skeletons
	}



}
