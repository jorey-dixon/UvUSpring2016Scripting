using UnityEngine;
using System.Collections;

public class FireBallista : MonoBehaviour {

	// Use this for initialization
	public Animator anim;
	void Start () {
		anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Space)) 
		{
			anim.SetBool ("Hold", true);
		}
		if (Input.GetKeyUp (KeyCode.Space)) 
		{
			anim.SetBool ("Hold", false);
		}
	
	}
}
