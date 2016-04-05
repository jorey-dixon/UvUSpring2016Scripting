using UnityEngine;
using System.Collections;

public class Castle : MonoBehaviour {

	public bool CastleGateIsUp = true;
	private GameObject ball;
	public GameObject QuestPostion;
	public GameObject thisObject;
	public Sprite castleUp;
	public Sprite castleDown;
	public GameObject projectile;
	public Transform projectileSpawn;
	private bool fire;


	void Start()
	{

	}

	void OnTriggerExit2D ( Collider2D other)
	{ 
		if (other.gameObject.tag == "Player")
		{
			AudioPlayer.OnPlayNoise += PlayDrawBridge;
			Debug.Log ("Ouch!");
			print("I'm detecting");
			if (CastleGateIsUp == true) {
			
				PublicVars.score += 100;
				PlayDrawBridge();
				CastleGateIsUp = false;
				thisObject.GetComponent<SpriteRenderer>().sprite = castleDown;
				print ("stage1");
			} else if (CastleGateIsUp == false) {
				ball = other.gameObject;
				other.gameObject.GetComponent<Rigidbody2D> ().isKinematic = true;
				other.gameObject.GetComponent<SpriteRenderer> ().enabled = false;
				print ("castle is up");
				PlayDrawBridge();

				StartCoroutine (Quest ());

			}
		}

	}
	void PlayDrawBridge()
	{
		AudioPlayer.playme = true;
		if (CastleGateIsUp == true) 
		{
			AudioPlayer.NoiseNumber = 4;
		} 
		 if (CastleGateIsUp == false) 
		{
			AudioPlayer.NoiseNumber = 5;
		}

		 if (fire == true) 
		{
			AudioPlayer.NoiseNumber = 10;
			fire = false;
		}
	
	}

	void fireCannonball()
	{
		print ("fireonce");
		fire = true;
		PlayDrawBridge ();
		GameObject clone;
		clone = Instantiate (projectile, projectileSpawn.position, transform.rotation) as GameObject;
		clone.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 20+Vector2.right*10;
	}

	IEnumerator Quest()
	{
		//play quest fanfaire
		print ("begin quest");
		bool fireme;
		fireme = true;
		yield return new WaitForSeconds (1.5f);

		if (fireme == true) {
			fireme = false;
			fireCannonball();
		}
		yield return new WaitForSeconds (.5f);
		
		print ("end quest");
		ball.gameObject.GetComponent<Rigidbody2D> ().isKinematic = false;
		ball.gameObject.GetComponent<SpriteRenderer>().enabled = true;
		ball.transform.position = QuestPostion.transform.position;
		thisObject.GetComponent<SpriteRenderer>().sprite = castleUp;
		CastleGateIsUp = true;



	}

}
