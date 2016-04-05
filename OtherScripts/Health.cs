using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	int num;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (PublicVars.playerHP == 0)

			Application.LoadLevel (3);

		//if (Time.deltaTime < 0.02f) {
		//} else if (Time.deltaTime > 0.02 && Time.deltaTime < 0.5) 
	//	{
		//	this.GetComponent<Rigidbody2D> ().velocity = this.GetComponent<Rigidbody2D> ().velocity * .5f;
	//	}


	//	print ("Frame Time" + num + "" + Time.deltaTime);
	
	}
}
