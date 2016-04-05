using UnityEngine;
using System.Collections;

public class TimeTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown (KeyCode.P))
		{

			if (Time.timeScale == 1) {	

				Time.timeScale = 0;
				StartCoroutine(timeLoop ());

			} else {
				//Time.timeScale = 1;

			}

	
	}
}
	IEnumerator timeLoop()
	{
		float pauseEndTime = Time.realtimeSinceStartup +10;
		while(Time.realtimeSinceStartup < pauseEndTime)
		{
			yield return 0;
		}
		Time.timeScale =1;
	}
}