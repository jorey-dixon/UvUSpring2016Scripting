using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public GameObject player;
	private Vector3 gpos;
	private Vector3 pos1=new Vector3 (2.17f, .25f, -10f);
	private Vector3 pos2=new Vector3 (2.17f, -13f, -10f);
	private Vector3 pos3= new Vector3 (2.17f, -26.5f, -10f);

	private bool move1= false;
	private bool move2 = false;
	private bool move3 = true;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {


		//transform.position = new Vector3(0,Mathf.Lerp(gameObject.transform.position.y, gpos.y, 1), -10);

		//transform.position = new Vector3(0,Mathf.Lerp(gameObject.transform.position.y, pos2.y, Time.time), -10);


		if (player.transform.position.y < 7 && player.transform.position.y > -5) {

			//transform.position = pos1;
			PublicVars.Bottom = false;
			PublicVars.Middle = false;
			PublicVars.Top = true;
			move1 = true;
			move2 = false;
			move3 = false;

		} else if (player.transform.position.y < -6 && player.transform.position.y > -20) {
			//transform.position = pos2;
			PublicVars.Bottom = false;
			PublicVars.Middle = true;
			PublicVars.Top = false;
			move1 = false;
			move2 = true;
			move3 = false;
		} else if (player.transform.position.y < -20) {
		
			//	transform.position = pos3;
			PublicVars.Bottom = true;
			PublicVars.Middle = false;
			PublicVars.Top = false;
			move1 = false;
			move2 = false;
			move3 = true;
		}





		if (move1 == true) 
		{
			transform.position = new Vector3(2.17f,Mathf.Lerp(gameObject.transform.position.y, pos1.y, Time.deltaTime*4), -10);
			//gpos = pos1;
		}
		if (move2 == true) 
		{
			//gpos = pos2;
			transform.position = new Vector3(2.17f,Mathf.Lerp(gameObject.transform.position.y, pos2.y, Time.deltaTime*4), -10);
		}
		if (move3 == true) 
		{
			//gpos = pos3;
			transform.position = new Vector3(2.17f,Mathf.Lerp(gameObject.transform.position.y, pos3.y, Time.deltaTime*4), -10);
		}

	}
}
