using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

	public Vector2 springPos;
	private float num;
	public Vector3 sub;
	public Vector3 sub2;
	public Vector3 sub3;

	// Use this for initialization
	void Start () {
		springPos.x = 0;
		springPos.y = -5000;
		sub.y = -0.02f;
		Audio2.OnPlayOtherNoises += Update;
	}
	
	// Update is called once per frame
	void Update () {




		if (Input.GetKey(KeyCode.Space))
		{
		

			if (num < 4)
			{
			this.transform.position += sub;
			StartCoroutine(Pullback());
			
			}
			print (this.transform.position);
			this.GetComponent<SpringJoint2D>().enabled = false;
		}

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			Audio2.NoiseNumber = 2;
			Audio2.playme = true;
		}

		if (Input.GetKeyUp(KeyCode.Space))
		{
			Audio2.NoiseNumber = 3;
			Audio2.playme = true;

			springPos.x = 0;
			springPos.y = -500;
			this.GetComponent<SpringJoint2D>().enabled = true;
			num = 0;

		}
	
	}

	IEnumerator Pullback()
	{

		yield return new WaitForSeconds(.25f);
		num++;

	}
}

