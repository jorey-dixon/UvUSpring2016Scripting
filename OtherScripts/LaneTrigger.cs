using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LaneTrigger : MonoBehaviour {

	public GameObject[] classSelect;
	public GameObject player;

	void Start()
	{
		AudioPlayer.OnPlayNoise += PlayClassSounds;
	}

	void PlayClassSounds()
	{

		if (PublicVars.Mage == true) {
			AudioPlayer.NoiseNumber = 7;
			AudioPlayer.playme = true;
		} else if (PublicVars.Rogue == true) {
			AudioPlayer.NoiseNumber = 8;
			AudioPlayer.playme = true;
		} else if (PublicVars.Warrior == true) {
			AudioPlayer.NoiseNumber = 9;
			AudioPlayer.playme = true;
		} else
			Debug.Log ("noClassSelectedInLaneTrigger");
	}

		void OnTriggerEnter2D (Collider2D coll)
	{

		if (coll.gameObject.tag == "player") {
			PublicVars.score += 100;
		}

		if (PublicVars.ClassSelected == false) {
			if (this.gameObject.name == "rogueSelect") {
				print ("rogue");
				PublicVars.ClassSelected = true;
				player.GetComponent<SpriteRenderer>().color = Color.green;
				PublicVars.Rogue = true;
				PlayClassSounds();


			} else if (this.gameObject.name == "mageSelect") {
				print ("mage");
				PublicVars.ClassSelected = true;
				player.GetComponent<SpriteRenderer>().color = Color.blue;
				PublicVars.Mage = true;
				PlayClassSounds();

			} else if (this.gameObject.name == "warriorSelect") {
				print ("warrior");
				PublicVars.ClassSelected = true;
				player.GetComponent<SpriteRenderer>().color = Color.red;
				PublicVars.Warrior = true;
				PlayClassSounds();


			}
	
		
		}


	}


}

