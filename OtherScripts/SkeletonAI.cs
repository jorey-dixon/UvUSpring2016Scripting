using UnityEngine;
using System.Collections;

public class SkeletonAI : MonoBehaviour {
	
	public Vector3 point1;
	public Vector3 point2;
	private float test;
	private bool CanDamage;
	public int HP = 2;
	public int soundNum;

	public Sprite down;
	public Sprite up;
	//needs to public points to move between
	
	// Use this for initialization
	void Start () {
		PublicVars.ResetZombies = false;
		Audio3.OnPlayEnemyNoises += Soundplay;
		this.gameObject.GetComponent<Rigidbody2D> ().velocity = Vector2.up*-.45f;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (this.gameObject.transform.position.y >= point1.y) {
			this.gameObject.GetComponent<Rigidbody2D> ().velocity = Vector2.up*-.45f;
			this.gameObject.GetComponent<SpriteRenderer>().sprite = down;
		} else if (this.gameObject.transform.position.y <= point2.y) {
			this.gameObject.GetComponent<Rigidbody2D> ().velocity = Vector2.up * .45f;
			this.gameObject.GetComponent<SpriteRenderer>().sprite =  up;
			
		}
		
		///ResetZombies ();
		if (PublicVars.ResetSkele == true|| PublicVars.ResetZombies == true) {
			PublicVars.ResetSkele = false;
			StartCoroutine (ResetZombiesss ());
		}
		//print (PublicVars.ResetZombies);
		
		
	}
	
	IEnumerator ResetZombiesss()
	{
		//play coming out of the ground anim

			CanDamage = true;
			this.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			this.gameObject.GetComponent<Rigidbody2D> ().velocity = Vector2.up*.45f;
			this.gameObject.GetComponent<BoxCollider2D> ().enabled = true;
			
			
			HP = 2;
			

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
			//change these to the correct sounds
			Audio3.playme = true;
			Audio3.NoiseNumber = 6;
			break;
		case 2:
			Audio3.playme = true;
			Audio3.NoiseNumber = 6;
			break;
		case 3:
			Audio3.playme = true;
			Audio3.NoiseNumber = 7;
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
			PublicVars.playerHP = PublicVars.playerHP-1;
			//play hurt noise
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
