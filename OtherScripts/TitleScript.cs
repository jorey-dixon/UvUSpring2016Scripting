using UnityEngine;
using System.Collections;

public class TitleScript : MonoBehaviour {
	
		public delegate void PlaySound ();
		public static event PlaySound OnPlayTitleNoises;
		public AudioClip[] Sounds;
		public static bool playme;
		public static int NoiseNumber;
		
		void Update()
		{
			if (playme == true)
				playMyNoise();
			playme = false;
		}
		
		void playMyNoise () 
		{
			//print (NoiseNumber);
			
			this.GetComponent<AudioSource> ().loop = false;
			this.GetComponent<AudioSource> ().mute = false;
			this.GetComponent<AudioSource> ().clip = Sounds [NoiseNumber];
			print ("playmynoise");
			if (OnPlayTitleNoises != null) 
			{
				OnPlayTitleNoises ();
				this.GetComponent<AudioSource> ().Play ();
				print ("i'm playing");
				playme = false;
			}
			
			
		}
	}
