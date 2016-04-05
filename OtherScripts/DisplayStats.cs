using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayStats : MonoBehaviour {

	public float hpScore;
	public float enemyBallscore;
	public float playerBallScore;
	public Text TextDisplay;


	void Update()
	{
		
		TextDisplay.text = ("Score:" + PublicVars.score);


	}

}
