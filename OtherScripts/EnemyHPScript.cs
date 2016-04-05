using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EnemyHPScript : MonoBehaviour {

	public float test;

	void Update () 
	{
		this.GetComponent<Slider> ().value = PublicVars.EnemyHP / 10;//1 - PublicVars.score / 10000;
		test = this.GetComponent<Slider>().value;

		if (test == 0f)
			print ("You Won!!!!!");
	
	}
}
