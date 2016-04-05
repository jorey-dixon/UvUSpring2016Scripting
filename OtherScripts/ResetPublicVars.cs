using UnityEngine;
using System.Collections;

public class ResetPublicVars : MonoBehaviour {

	// Use this for initialization
	void Start () {
		System.GC.Collect();
		PublicVars.leftGateHp = 5;

		PublicVars.rightGateHp = 5;
		PublicVars.score = 0;
		PublicVars.specialAttackCounter= 0;
		PublicVars.ClassSelected= false;
		PublicVars.Mage= false;
		PublicVars.Rogue= false;
		PublicVars.Warrior = false;
		PublicVars.GateUP = false;
		PublicVars.HP = 1f;
		PublicVars.ResetZombies = false;
		PublicVars.ResetSkele = false;
		PublicVars.ResetWall = false;
		PublicVars.playerHP = 15;
		PublicVars.EnemyHP = 10;
		PublicVars.skeletonSummon = false;

		PublicVars.WallHP1 = 5;
		PublicVars.WallHP2 = 5;
		PublicVars.WallHP3 = 5;
		PublicVars.WallHP4 = 5;
		PublicVars.WallHP5 = 5;
		PublicVars.Quest1Comp = false;
		PublicVars.QuestCounter = 0;
		PublicVars.level2DTrigger = false;
		PublicVars.level3DTrigger = false;
		PublicVars.resetLaunchTrigger = false;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
