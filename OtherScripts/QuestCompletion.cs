using UnityEngine;
using System.Collections;

public class QuestCompletion : MonoBehaviour {

	public int questDifficulty = 3;
	void Start()
	{
		//add audio stuff for quest complete
	}

	void Update () {

		Quest();

	
	}

	void Quest()
	{
		if (PublicVars.QuestCounter == questDifficulty) 
		{
			print("QuestComplete");
			PublicVars.Quest1Comp = true;
			//Play Success Noise
		}

	}
}
