using UnityEngine;
using System.Collections;

public class CollideWithObjects : MonoBehaviour {

		int classNoise = 0;
	private Vector3 startingSize = new Vector3 (1.4f,1.4f,1.4f);
	void start()
	{
		//this.gameObject.transform.localScale = startingSize;

	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		this.gameObject.transform.localScale = this.gameObject.transform.localScale * .75f;
		StartCoroutine (Resize ());
		PublicVars.QuestCounter = PublicVars.QuestCounter + 1;

		if (PublicVars.Mage == true)
		{
			classNoise = 1;
		}
		else if (PublicVars.Rogue == true)
		{
			classNoise = 2;
		}
		else if (PublicVars.Warrior == true)
		{
			classNoise = 3;
		}
		else
		{
			classNoise = 0;
		}
		print (classNoise);
		if(coll.gameObject.name == "Player_Ball")
		{
			AudioPlayer.OnPlayNoise += FindNameNoise;
			print ("finding object noise");
			FindNameNoise();
		}
	}


	void FindNameNoise()
	{

		if (this.name == "Bumper") 
		{

			print ("i hit bumper 1");
			AudioPlayer.playme = true;
			AudioPlayer.NoiseNumber = classNoise;
			PublicVars.score += 50;
		}
		if (this.name == "Bumper1")
		{

			print ("i hit bumper 2");
			AudioPlayer.playme = true;
			AudioPlayer.NoiseNumber = classNoise;
			PublicVars.score += 50;
		}
		if (this.name == "Bumper2") 
		{

			print ("i hit bumper 3");
			AudioPlayer.playme = true;
			AudioPlayer.NoiseNumber = classNoise;
			PublicVars.score += 50;
		}

	}

	IEnumerator Resize()
	{
		yield return new WaitForSeconds (.5f);
		this.gameObject.transform.localScale = startingSize;

	}


}
