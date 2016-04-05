using UnityEngine;
using System.Collections;

public class BrokenWall2 : MonoBehaviour {

	public int HP = 5;
	public Sprite Wall0;
	public Sprite Wall1;
	public Sprite Wall2;
	public Sprite Wall3;
	public Sprite Wall4;
	public Sprite Wall5;
	// Use this for initialization
	//check this if there is a problem
	void Start () 
	{
		Audio3.OnPlayEnemyNoises += SoundPlay;

	}

	void Update () 
	{
		if (PublicVars.ResetWall == true) 
		{
			HP = 5;
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall0;
			this.gameObject.GetComponent<BoxCollider2D> ().enabled = true;
		}
	}

	void SoundPlay()
	{
		Audio3.playme = true;
		Audio3.NoiseNumber = 3;
	}
	// Update is called once per frame
	void OnCollisionExit2D(Collision2D col)
	{
		HP--;
		SoundPlay ();
		if(HP == 5)
	{
		this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall0;
		this.gameObject.GetComponent<BoxCollider2D> ().enabled = true;
		} else if (HP == 4) {
		this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall1;
		} else if (HP == 3) {
		this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall2;
		} else if (HP == 2) {
		this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall3;
		} else if (HP == 1) {
		this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall4;
		} else if (HP <= 0) {
		this.gameObject.GetComponent<SpriteRenderer> ().sprite = Wall5;
		this.gameObject.GetComponent<BoxCollider2D> ().enabled = false;
	} else {
		print ("WallHealth1???");
	}
	
	}
}
