using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public Vector3 point1;
	public Vector3 point2;
	private float test;
	private bool CanDamage;
	public int HP;
	public int soundNum;

	//needs to public points to move between

	// Use this for initialization
	void Start () {
		PublicVars.ResetZombies = false;
		Audio3.OnPlayEnemyNoises += Soundplay;
		this.gameObject.GetComponent<Rigidbody2D> ().velocity = Vector2.left*.5f;
	}
	
	// Update is called once per frame
	void Update () {

		if (this.gameObject.transform.position.x >= point1.x) {
			this.gameObject.GetComponent<Rigidbody2D> ().velocity = Vector2.left*.5f;
			transform.localScale = new Vector3 (1f,1f,1f);
		} else if (this.gameObject.transform.position.x <= point2.x) {
			this.gameObject.GetComponent<Rigidbody2D> ().velocity = Vector2.left * -.5f;
			transform.localScale = new Vector3 (-1f,1f,1f);

		}

		///ResetZombies ();
		StartCoroutine (ResetZombiesss ());
		//print (PublicVars.ResetZombies);


	}
	
	IEnumerator ResetZombiesss()
	{
		//play coming out of the ground anim
		if (PublicVars.ResetZombies == true) 
		{
			CanDamage = true;
			this.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			this.gameObject.GetComponent<Rigidbody2D> ().velocity = Vector2.left*.5f;
			this.gameObject.GetComponent<BoxCollider2D> ().enabled = true;
		

			HP = 2;

		}
		yield return new WaitForSeconds(.05f);
		PublicVars.ResetZombies = false;

/*	public void ResetZombies()
	{
		//play coming out of the ground anim
		if (PublicVars.ResetZombies == true) 
		{
			CanDamage = true;
			this.gameObject.GetComponent<SpriteRenderer> ().enabled = true;

			this.gameObject.GetComponent<BoxCollider2D> ().enabled = true;

			PublicVars.ResetZombies = false;
			HP = 2;
		}
*/


	}
	void Soundplay ()
	{
		switch (soundNum)
		{
		case 1:
		Audio3.playme = true;
		Audio3.NoiseNumber = 0;
		break;
		case 2:
		Audio3.playme = true;
		Audio3.NoiseNumber = 1;
		break;
		case 3:
		Audio3.playme = true;
		Audio3.NoiseNumber = 2;
		break;

		}


	}

	void Soundplay2 ()
	{

	}


	void OnCollisionEnter2D(Collision2D coll)
	{
		
		if(coll.gameObject.name == "Player_Ball")
		{
			HP--;
			//play hurt noise
			PublicVars.playerHP = PublicVars.playerHP-1;
			print ("hp= "+ HP);
			soundNum =1;
			Soundplay();
			
			if (HP <= 0) {
				this.gameObject.GetComponent<SpriteRenderer> ().enabled = false;
				this.gameObject.GetComponent<BoxCollider2D> ().enabled = false;
				soundNum =3;
				Soundplay();
				print ("zombie dead");

			}
			else if (CanDamage ==true)
			{
				//hurtplayer
				Soundplay2();
				soundNum =2;
				print ("hurtplayer");
					CanDamage = false;
				}

			}

			
		}
}
