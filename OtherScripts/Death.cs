using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	public GameObject respawnPoint1;
	public GameObject respawnPoint2;
	public GameObject respawnPoint3;
	public GameObject[]TriggerResets;
	public GameObject Lv1Death;
	public GameObject Lv2Death;
	public GameObject Lv3Death;

	void Start()
	{
		AudioPlayer.OnPlayNoise += Soundplay;
	}

	void Update(){
		if (Input.GetKey (KeyCode.Escape))
			Application.Quit ();
	}
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D col)
	{
		if (this.gameObject.tag == "Player") {
			if (col.gameObject == Lv1Death.gameObject) { //bug here
				this.transform.position = respawnPoint1.transform.position;
				PublicVars.ClassSelected = false;
				PublicVars.playerHP = PublicVars.playerHP-1;
				TriggerResets [0].GetComponent<SpriteRenderer> ().color = Color.white;
				TriggerResets [1].GetComponent<SpriteRenderer> ().color = Color.white;
				TriggerResets [2].GetComponent<SpriteRenderer> ().color = Color.white;
				PublicVars.Mage = false;
				PublicVars.Warrior = false;
				PublicVars.Rogue = false;
				PublicVars.GateUP = false;
				PublicVars.ResetWall = true;
				PublicVars.HP += -.25f;
				PublicVars.ResetZombies = true;
				PublicVars.resetLaunchTrigger = true;
				Soundplay ();
			} else if (col.gameObject == Lv2Death.gameObject) {
				this.transform.position = respawnPoint1.transform.position;
				PublicVars.ClassSelected = false;
				PublicVars.playerHP = PublicVars.playerHP-1;
				TriggerResets [0].GetComponent<SpriteRenderer> ().color = Color.white;
				TriggerResets [1].GetComponent<SpriteRenderer> ().color = Color.white;
				TriggerResets [2].GetComponent<SpriteRenderer> ().color = Color.white;
				PublicVars.Mage = false;
				PublicVars.Warrior = false;
				PublicVars.Rogue = false;
				PublicVars.GateUP = false;
				PublicVars.ResetWall = true;
				PublicVars.HP += -.25f;
				PublicVars.ResetZombies = true;
				PublicVars.resetLaunchTrigger = true;
				Soundplay ();

			} else if (col.gameObject == Lv3Death.gameObject) {
				this.transform.position = respawnPoint3.transform.position;
				PublicVars.ClassSelected = false;
				PublicVars.playerHP = PublicVars.playerHP-1;
				TriggerResets [0].GetComponent<SpriteRenderer> ().color = Color.white;
				TriggerResets [1].GetComponent<SpriteRenderer> ().color = Color.white;
				TriggerResets [2].GetComponent<SpriteRenderer> ().color = Color.white;
				PublicVars.Mage = false;
				PublicVars.Warrior = false;
				PublicVars.Rogue = false;
				PublicVars.GateUP = false;
				PublicVars.ResetWall = true;
				PublicVars.HP += -.25f;
				PublicVars.ResetZombies = true;
				PublicVars.resetLaunchTrigger = true;
				Soundplay ();
							
			} else {
				//this.transform.position = respawnPoint1.transform.position;


			}
		}
	}

	void Soundplay()
		{
			AudioPlayer.playme = true;
			AudioPlayer.NoiseNumber = 6;

		}


}
