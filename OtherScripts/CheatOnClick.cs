using UnityEngine;
using System.Collections;

public class CheatOnClick : MonoBehaviour {

	public GameObject vectorPos;

	void Start()
	{
		this.GetComponent<Rigidbody2D> ().gravityScale = 0;
	}

	void OnMouseDown()
	{
		this.transform.position = vectorPos.transform.position;


	}
	

}
