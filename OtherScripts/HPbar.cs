using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPbar : MonoBehaviour {

	void Update () 
	{
		this.GetComponent<Slider>().value = PublicVars.playerHP/10;

		if (PublicVars.playerHP <= 0.5f) 
		{
			print ("YOU ARE DEAD MWAHAHAHAHAHAHAHA!!!!!");
		}
		
	}
}
