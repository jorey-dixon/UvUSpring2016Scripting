using UnityEngine;
using System.Collections;

public class DragonMove : MonoBehaviour {
	public GameObject dragonSprite;
	public GameObject dragonLerp;
	public float speed = 0.25f;
	public bool cheatset = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (PublicVars.moveDragon == true) 
		{
			dragonSprite.transform.position = new Vector3 (Mathf.Lerp (dragonSprite.transform.position.x, dragonLerp.transform.position.x, Time.deltaTime * speed),0,0);

		}
	
	}
}
