using UnityEngine;
using System.Collections;

public class CollideRandom : MonoBehaviour {

	public float col1;
	public float col2;
	public float col3;
	public Animator anim;
	void Start()
	{
		Audio3.OnPlayEnemyNoises += SoundPlay;

		if (this.gameObject.name == "cow") {
			anim = this.GetComponent<Animator> ();
		}
	}


	void OnCollisionExit2D(Collision2D coll)
	{
		if (this.gameObject.tag != "PlaySound") {		

			if (coll.gameObject.name == "Player_Ball") {
				col1 = Random.value;
				col2 = Random.value;
				col3 = Random.value;
				this.gameObject.GetComponent<SpriteRenderer> ().color = new Color (col1, col2, col3, 1);
		
			}
		} else if (this.gameObject.tag == "PlaySound")


		{
			PublicVars.playerHP = PublicVars.playerHP + 1;
			SoundPlay();
		}

	}

	void Update()
	{
		if (PublicVars.GateUP == false)
			this.GetComponent<SpriteRenderer> ().color = Color.white;
	}

	void SoundPlay()
	{


		if (this.gameObject.name == "cow") {
			Audio3.playme = true;
			Audio3.NoiseNumber = 5;
		}
		if (this.gameObject.name == "Fountain") 
		{
			Audio3.playme = true;
			Audio3.NoiseNumber = 6;
			print ("i'm playing hte right sound");
		}
	
		if (anim != null) {
			anim.SetBool ("moo", true);
			StartCoroutine (stopMoo ());
		}

	}

	IEnumerator stopMoo()
	{
		yield return new WaitForSeconds (.25f);
		if (anim != null) {
			anim.SetBool ("moo", false);
		}

	}
	
}
