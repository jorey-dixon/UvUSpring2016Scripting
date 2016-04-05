using UnityEngine;
using System.Collections;

public class RightFlipper : MonoBehaviour {

	private bool startup;
	public Vector2 startPos;
	public Quaternion startRot;
	public Vector2 startPos2;
	public Quaternion startRot2;
	public Vector2 thisVeloc;
	public Vector2 lerppos;
	
	
	// Use this for initialization
	void Start () {
		
		
		//	HingeJoint2D hinge = this.GetComponent<HingeJoint2D> ();
		//JointMotor2D motor = hinge.motor;
		//motor. = 0;
		//motor.targetVelocity = 100000;
		startPos = this.transform.position;
		startRot = this.transform.rotation;
		lerppos = this.GetComponent<Rigidbody2D> ().velocity;
		Audio2.OnPlayOtherNoises += Update;

	}

	// Update is called once per frame
	void Update () {
		
		
		
		if (Input.GetKeyDown (KeyCode.Slash )) 
		{

						this.GetComponent<Rigidbody2D>().AddForce(Vector2.up*5000);
			Audio2.NoiseNumber = 0;
			Audio2.playme = true;

			
			
			
		}
		else if ( Input.GetKeyUp (KeyCode.Slash))
		{
			//AudioPlayer.OnPlayNoise += PlayFlippers;
			Audio2.NoiseNumber = 1;
			Audio2.playme = true;

			this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			
			
			
			this.transform.position = startPos;
			this.transform.rotation = startRot;
			
			
		}
		
		
	}
}
