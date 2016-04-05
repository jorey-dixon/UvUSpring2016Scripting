using UnityEngine;
using System.Collections;

public class textBoxTest : MonoBehaviour {

	public GameObject Window;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D col)
	{
		print ("Yay");
		Window.GetComponent<SpriteRenderer> ().enabled = true;
	}
}
