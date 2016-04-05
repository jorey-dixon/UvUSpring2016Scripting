using UnityEngine;
using System.Collections;

public class chickenCoupe : MonoBehaviour {

	public bool expelPlayer = false;
	public GameObject player;
	public GameObject expelPlayerPosition;

	void Start()
	{
		AudioPlayer.OnPlayNoise += PlaySound;

	}

	void Update()
	{

	}


	void OnTriggerEnter2D ( Collider2D other)
	{ 
		if (other.gameObject.tag == "Player")
		{

			other.gameObject.GetComponent<Rigidbody2D> ().isKinematic = true;
			other.gameObject.GetComponent<SpriteRenderer> ().enabled = false;
			expelPlayer = true;
			PlaySound ();
		}


	}

	void PlaySound()

	{
		AudioPlayer.playme = true;
		AudioPlayer.NoiseNumber = 11;
		StartCoroutine (waitforSound());

	}

	IEnumerator waitforSound()
	{
	
		yield return new WaitForSeconds(.5f);
		if (expelPlayer == true) {
			expelPlayer = false;
			player.transform.position = expelPlayerPosition.transform.position;
			player.gameObject.GetComponent<Rigidbody2D> ().isKinematic = false;
			player.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			player.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 15;
		}


	}
}
