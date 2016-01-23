using UnityEngine;
using System.Collections;

public class TurnBasedCombatStateMachine : MonoBehaviour {

	public enum BattleStates {
		START,
		PLAYERCHOICE,
		//PLAYERANIMATE, // This is where you could add a animation function
		ENEMYCHOICE,
		LOSE,
		WIN
	}

	private BattleStates currentState;



	// Use this for initialization
	void Start () {
		currentState = BattleStates.START;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(currentState);
		switch (currentState) {
		case (BattleStates.START):
			// set up battle function could go here
			break;
		case (BattleStates.PLAYERCHOICE):
			break;
		case (BattleStates.ENEMYCHOICE):
			break;
		case (BattleStates.LOSE):
			break;
		case (BattleStates.WIN):
			break;
		} 
	}
	void OnGUI(){
		if (GUILayout.Button ("Next State")) {
			if (currentState == BattleStates.START) {
				currentState = BattleStates.PLAYERCHOICE;          
			}else if (currentState == BattleStates.PLAYERCHOICE) {
				currentState = BattleStates.ENEMYCHOICE;          
			}else if (currentState == BattleStates.ENEMYCHOICE) {
				currentState = BattleStates.LOSE;          
			}else if (currentState == BattleStates.LOSE) {
				currentState = BattleStates.WIN;          
			}else if (currentState == BattleStates.WIN) {
				currentState = BattleStates.START;          
			}
		}
	}
}
