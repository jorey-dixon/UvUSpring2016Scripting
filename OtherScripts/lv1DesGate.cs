using UnityEngine;
using System.Collections;

public class lv1DesGate : MonoBehaviour {
	public int Health = 10;
	public GameObject parentObject;
	public Sprite spriteDown;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Health == 0|| PublicVars.Quest1Comp == true) 

		{
			this.GetComponent<BoxCollider2D>().enabled = false;
			parentObject.GetComponent<SpriteRenderer>().sprite = spriteDown;


		}
	
	}
}
