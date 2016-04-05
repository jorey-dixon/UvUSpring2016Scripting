using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextImport3 : MonoBehaviour {
	
	public GameObject textBox;
	
	public Text theText;
	
	public bool startOnce = false;
	public TextAsset textfile;
	public string[] textLines;
	
	public int currentLine;
	public int endAtLine;
	
	private bool isActive = true;
	
	private bool isTyping = false;
	
	private bool cancelTyping = false;
	
	public float Typespeed = 10f;
	private int messageNum= 0;
	public bool isPaused = false;
	public bool hasread = false;
	public GameObject finalPanel;
	public GameObject finalPanel2;
	public Sprite EvilWizard;
	public GameObject QuestionmarkImage;
	
	//Pause player
	
	
	// Use this for initialization
	void Start () {
		AudioPlayer.OnPlayNoise += playSound;
		
		if (textfile != null) 
		{
			textLines = (textfile.text.Split('\n'));
		}
		
		if (endAtLine == 0) 
		{
			endAtLine = textLines.Length - 1;
		}
		
	}
	
	public void EnableTextBox()
	{
		if(!hasread)
		{
			
			hasread = true;
			textBox.SetActive (true);
			isActive = true;
			QuestionmarkImage.GetComponent<Image>().sprite = EvilWizard;
			StartCoroutine(TextScroll(textLines[currentLine]));
			Time.timeScale = 0.0001f;
			finalPanel.SetActive(true);
			finalPanel2.SetActive(true);
			if (startOnce == false)
			{
			startOnce = true;
			PublicVars.skeletonSummon = true;
			}
			playSound();
		}
		
		//pause player
		
	}

	public void playSound()
	{
		AudioPlayer.playme = true;
		AudioPlayer.NoiseNumber = 12;
	}
	
	public void DisableTextBox()
	{
		textBox.SetActive (false);
		isPaused = false;
		isActive = false;
		
		float pausetypeTime = Time.realtimeSinceStartup+1f;
		
		
		while(Time.realtimeSinceStartup<pausetypeTime)
		{
			print ("waiting");
			
		}
		
		
		Time.timeScale = 1;
		PublicVars.level2DTrigger = true;
		//resume player
		
	}
	
	void Update()
	{
		if (!isActive || PublicVars.level3DTrigger == false) 
		{
			return;
		}
		//theText.text = textLines [currentLine];
		
		if (Input.GetKeyDown (KeyCode.Return)) 
		{
			
			
			if(!isTyping)
			{
				currentLine+=1;
				messageNum = messageNum + 1;
				
				if (currentLine > endAtLine)
				{
					DisableTextBox();
				}
				else
				{
					StartCoroutine(TextScroll(textLines[currentLine]));
				}
				
			} else if (isTyping && !cancelTyping)
			{
				cancelTyping = true;
				
			}
			
		}
		
		
		
		
	}
	
	private IEnumerator TextScroll(string lineOfText)
		
	{
		int letter = 0;
		theText.text = "";
		isTyping = true;
		cancelTyping = false;
		
		float pausetypeTime = Time.realtimeSinceStartup+.05f;
		
		
		while(isTyping && !cancelTyping && (letter < lineOfText.Length - 1))
		{
			
			
			theText.text += lineOfText[letter];
			letter+=1;
			
			
			
			while(Time.realtimeSinceStartup<pausetypeTime)
			{
				print ("waiting");
				
			}
			pausetypeTime = Time.realtimeSinceStartup+.05f;
			//yield return new WaitForSeconds(Typespeed);
			yield return null;
			
		}
		
		
		theText.text = lineOfText;
		isTyping = false;
		cancelTyping = false;
		
		
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (isPaused == false) 
		{
			
			
			if (col.gameObject.tag == "Player"&& this.gameObject.name =="FinalLevel") 
			{
				PublicVars.level3DTrigger = true;
				isPaused = true;
				EnableTextBox ();

			}
		}
	}
	
	
	
	
}