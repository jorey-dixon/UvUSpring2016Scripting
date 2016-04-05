using UnityEngine;
using System.Collections;

public class WallBreak : MonoBehaviour {


	private int WallNumberInt = 0;
	public Sprite Wall0;
	public Sprite Wall1;
	public Sprite Wall2;
	public Sprite Wall3;
	public Sprite Wall4;
	public Sprite Wall5;
	private int wallNoise = 4;
	public GameObject player;
	public Transform nextlevel;


	//Need to assign all wall sprites
	//Needs to be on each object


	void Start()
	{
		Audio3.OnPlayEnemyNoises += SoundPlay;

		if (this.gameObject.name == "Wall1") {
			WallNumberInt = 1;
		} else if (this.gameObject.name == "Wall2") {
			WallNumberInt = 2;
		} else if (this.gameObject.name == "Wall3") {
			WallNumberInt = 3;
		} else if (this.gameObject.name == "Wall4") {
			WallNumberInt = 4;
		} else if (this.gameObject.name == "Wall5") {
			WallNumberInt = 5;
		} else {
			print ("oops");
		}



	}
	void Update()
	{
		WallHurt ();
	}

	void SoundPlay()
	{
		Audio3.playme = true;
		Audio3.NoiseNumber = wallNoise;
	}
	
	void WallHurt ()
	{
		switch (WallNumberInt) {
		case 1: 

			if (PublicVars.WallHP1 == 5) {
	
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall0;
				this.gameObject.GetComponent<BoxCollider2D> ().enabled = true;
			} else if (PublicVars.WallHP1 == 4) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall1;
			} else if (PublicVars.WallHP1 == 3) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall2;
			} else if (PublicVars.WallHP1 == 2) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall3;
			} else if (PublicVars.WallHP1 == 1) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall4;
			} else if (PublicVars.WallHP1 <= 0) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall5;
				this.gameObject.GetComponent<BoxCollider2D> ().isTrigger = true;
			} else {
				print ("WallHealth1???");
			}

			break;

		case 2: 
			if (PublicVars.WallHP2 == 5) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall0;
				this.gameObject.GetComponent<BoxCollider2D> ().enabled = true;
			} else if (PublicVars.WallHP2 == 4) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall1;
			} else if (PublicVars.WallHP2 == 3) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall2;
			} else if (PublicVars.WallHP2 == 2) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall3;
			} else if (PublicVars.WallHP2 == 1) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall4;
			} else if (PublicVars.WallHP2 <= 0) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall5;
				this.gameObject.GetComponent<BoxCollider2D> ().isTrigger = true;
			} else {
				print ("WallHealth1???");
			}


			
			break;

		case 3: 
			if (PublicVars.WallHP3 == 5) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall0;
				this.gameObject.GetComponent<BoxCollider2D> ().enabled = true;
			} else if (PublicVars.WallHP3 == 4) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall1;
			} else if (PublicVars.WallHP3 == 3) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall2;
			} else if (PublicVars.WallHP3 == 2) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall3;
			} else if (PublicVars.WallHP3 == 1) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall4;
			} else if (PublicVars.WallHP3 <= 0) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall5;
				this.gameObject.GetComponent<BoxCollider2D> ().isTrigger = true;
			} else {
				print ("WallHealth1???");
			}

			break;

		case 4: 
		

			if (PublicVars.WallHP4 == 5) {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall0;
			this.gameObject.GetComponent<BoxCollider2D> ().enabled = true;
		} else if (PublicVars.WallHP4 == 4) {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall1;
		} else if (PublicVars.WallHP4 == 3) {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall2;
		} else if (PublicVars.WallHP4 == 2) {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall3;
		} else if (PublicVars.WallHP4 == 1) {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall4;
		} else if (PublicVars.WallHP4 <= 0) {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall5;
			this.gameObject.GetComponent<BoxCollider2D> ().isTrigger = true;
		} else {
			print ("WallHealth1???");
		}

			break;

		case 5: 
			if (PublicVars.WallHP5 == 5) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall0;
				this.gameObject.GetComponent<BoxCollider2D> ().enabled = true;
			} else if (PublicVars.WallHP5 == 4) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall1;
			} else if (PublicVars.WallHP5 == 3) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall2;
			} else if (PublicVars.WallHP5 == 2) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall3;
			} else if (PublicVars.WallHP5 == 1) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall4;
			} else if (PublicVars.WallHP5 <= 0) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall5;
				this.gameObject.GetComponent<BoxCollider2D> ().isTrigger = true;
			} else {
				print ("WallHealth1???");
			}
		
			break;
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{

		if (col.gameObject.tag == "Player") {
			wallNoise =3;
			SoundPlay ();
			print (this.gameObject.name + "ouch");

		

			if (this.gameObject.name == "Wall1") 
			{
				PublicVars.WallHP1 = PublicVars.WallHP1 -1;
			}
			else if (this.gameObject.name == "Wall2") 
			{
				PublicVars.WallHP2 = PublicVars.WallHP2 -1;

			}
			else if (this.gameObject.name == "Wall3") 
			{
				PublicVars.WallHP3 = PublicVars.WallHP3 -1;
			}
			else if (this.gameObject.name == "Wall4") 
			{
				PublicVars.WallHP4 = PublicVars.WallHP4 -1;
			}
			else if (this.gameObject.name == "Wall5") 
			{
				PublicVars.WallHP5 = PublicVars.WallHP5 -1;
			}
			WallHurt();
		}

		else if (col.gameObject.tag == "Cannon"|| col.gameObject.name == "CannonBall(Clone)") 
			{
			wallNoise =4;
			SoundPlay ();
			
			if(this.gameObject.name == "Wall2")
			{
				PublicVars.WallHP1 = PublicVars.WallHP1 -1;
				PublicVars.WallHP2 = PublicVars.WallHP2 -2;
				PublicVars.WallHP3 = PublicVars.WallHP3 -1;
				WallHurt();
				Destroy (col.gameObject);
			}
			
			else if(this.gameObject.name == "Wall4")
			{
				PublicVars.WallHP3 = PublicVars.WallHP3 -1;
				PublicVars.WallHP4 = PublicVars.WallHP4 -2;
				PublicVars.WallHP5 = PublicVars.WallHP5 -1;
				WallHurt();
				Destroy (col.gameObject);
			}



		}

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Cannon"|| col.gameObject.name == "CannonBall(Clone)") 
			Destroy(col.gameObject);
		player.transform.position = nextlevel.position;

		if (col.gameObject.tag == "Player") 
		{
			player.transform.position = nextlevel.position;
		}
	}


}
