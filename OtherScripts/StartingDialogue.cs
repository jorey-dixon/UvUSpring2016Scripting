using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class StartingDialogue : MonoBehaviour {

	public bool hasListened = false;
	private float realTime;
	private int messageNum= 0;
	private bool isPaused = false;

	public GameObject Window;



	void Start()
	{

			//"In order to prove yourself worth of the challenges you face before you, you must first complete a quest.";
			//"QUEST RECIEVED CONSOLE: HIT THE TARGETS 3 TIMES TO APPEASE THE OLD MAN"
			//" HEY I WAS GETTING TO THAT!!!! *Ahem* Hit them 3 Targets, and the gate will open to the Castle. Why you would want to go there is beyond me..."
		//	"I've heard it's been cursed by an evil Wizard, and only Zombies patrol those walls now.."
		//	"This gate's kinda old, Maybe you could open it by bashing your head against it a few times"
		

	}

	void Update()

	{
		print (messageNum);

		if(Input.GetKeyDown (KeyCode.Return))
		{
			messageNum = messageNum + 1;
		}


		/*if (messageNum >= 10) {

		
			if (Time.timeScale == 1) {	

				Time.timeScale = 0;

			} else {
				Time.timeScale = 1;
			}


			

		



			
		}
		*/
	}



	void OnTriggerEnter2D(Collider2D col)
	{
		if (isPaused == false) 
		{
			isPaused = true;
			if (col.gameObject.tag == "Player" && hasListened == false) 
			{
				isPaused = true;
			//	Time.timeScale = 0;
				Window.SetActive(true);
			/*
				print ("Welcome to the world of Pinballia Young Recruit.");
				print ("In order to prove yourself worth of the challenges you face before you, you must first complete a quest.");
				print ("QUEST RECIEVED CONSOLE: HIT THE TARGETS 3 TIMES TO APPEASE THE OLD MAN");
				print (" HEY I WAS GETTING TO THAT!!!! *Ahem* Hit them 3 Targets, and the gate will open to the Castle. Why you would want to go there is beyond me...");
				print ("I've heard it's been cursed by an evil Wizard, and only Zombies patrol those walls now..");

				print ("This gate's kinda old, Maybe you could open it by bashing your head against it a few times");
				hasListened = true;
				*/
			}

		}
	}


}
