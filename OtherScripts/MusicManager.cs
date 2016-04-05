using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
	
	public AudioSource topMusic;
	public AudioSource middleMusic;
	public AudioSource bottomMusic;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {





		if (PublicVars.Top == true) {

			topMusic.volume = Mathf.Lerp(topMusic.volume,1.0f, Time.deltaTime);
			middleMusic.volume =  Mathf.Lerp(middleMusic.volume,0f, Time.deltaTime);
			bottomMusic.volume =  Mathf.Lerp(bottomMusic.volume,0f, Time.deltaTime);

			

			
		} else if (PublicVars.Middle == true) {
			topMusic.volume =  Mathf.Lerp(topMusic.volume,0f, Time.deltaTime);
			middleMusic.volume =  Mathf.Lerp(middleMusic.volume,1f, Time.deltaTime);
			bottomMusic.volume =  Mathf.Lerp(bottomMusic.volume,0f, Time.deltaTime);


		} else if (PublicVars.Bottom == true) {
			topMusic.volume =  Mathf.Lerp (topMusic.volume,0f, Time.deltaTime);
			middleMusic.volume = Mathf.Lerp(middleMusic.volume,0f, Time.deltaTime);
			bottomMusic.volume =  Mathf.Lerp(bottomMusic.volume,1f, Time.deltaTime);
			
		

		}

		
		

	}
}
