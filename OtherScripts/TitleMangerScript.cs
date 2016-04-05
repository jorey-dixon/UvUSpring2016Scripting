using UnityEngine;
using System.Collections;

public class TitleMangerScript : MonoBehaviour {

	public GameObject[] buttons;
	private int menuSelect =1;
	private int choice;
	private bool Selection = false;
	// Use this for initialization
	void Start () {

		Screen.SetResolution (800, 600, false);
		TitleScript.OnPlayTitleNoises += MoveSelectionAndSound;

	}
	
	// Update is called once per frame
	void Update () {



	

		if (Input.GetKeyDown(KeyCode.UpArrow))

		    {
				menuSelect -=1;
			if (menuSelect < 1) 
			{
				menuSelect = 3;
			}
			MoveSelectionAndSound();
			}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		    
		    {
			menuSelect +=1;
			if (menuSelect > 3) 
			{
				menuSelect = 1;
			}
			MoveSelectionAndSound();
		}


		if (Input.GetKeyDown (KeyCode.Return)) 
		{
			choice = menuSelect;
			Selection = true; 
			MoveSelectionAndSound();


		}

	}


	void MoveSelectionAndSound()
	{
		if (Selection == true) {

			TitleScript.NoiseNumber = 1;
			TitleScript.playme = true;
			StartCoroutine(waitForMe());

		} else {


			TitleScript.NoiseNumber = 0;
			TitleScript.playme = true;
		

		switch (menuSelect) {
		case 1:
			buttons[0].SetActive(true);
			buttons[1].SetActive(false);
			buttons[2].SetActive(false);
			
			break;
		case 2:
			buttons[0].SetActive(false);
			buttons[1].SetActive(true);
			buttons[2].SetActive(false);
			
			break;
		case 3:
			buttons[0].SetActive(false);
			buttons[1].SetActive(false);
			buttons[2].SetActive(true);
			
			break;
			}
		}
			
		
	}

	void Selected()
	{
	
		switch (choice) 
		{
		case 1:
			Application.LoadLevel(choice);
			break;
		case 2:
			Application.LoadLevel(choice);
			break;
		case 3:
			Application.LoadLevel(4);
			break;

		}


	}
	IEnumerator waitForMe()
	{
		yield return new WaitForSeconds (.5f);
		Selected();
	}
}
