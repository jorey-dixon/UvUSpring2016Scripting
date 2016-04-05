using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerPortrait : MonoBehaviour {

	public Sprite Rogue;
	public Sprite Wizard;
	public Sprite Warrior;
	public Sprite NPC;

	void Update()
	{
		if (PublicVars.Rogue == true) {
			this.GetComponent<Image> ().sprite = Rogue;
		} else if (PublicVars.Warrior == true) {
			this.GetComponent<Image> ().sprite = Warrior;
		} else if (PublicVars.Mage == true) {
			this.GetComponent<Image> ().sprite = Wizard;
		} else {
			this.GetComponent<Image>().sprite = NPC;
		}

		
	}
}
