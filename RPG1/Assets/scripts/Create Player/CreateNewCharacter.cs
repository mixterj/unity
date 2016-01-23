using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CreateNewCharacter : MonoBehaviour {

	private BasePlayer newPlayer;
	private bool isMageClass;
	private bool isWarriorClass;
	private string playerName = "Enter Name";

	// Use this for initialization
	void Start () {
		newPlayer = new BasePlayer();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI (){
		playerName = GUILayout.TextArea (playerName,15);
		isMageClass = GUILayout.Toggle (isMageClass, "Mage Class");
		isWarriorClass = GUILayout.Toggle (isWarriorClass, "Warrior Class");
		if(GUILayout.Button("Create")){
			if(isMageClass){
				newPlayer.PlayerClass = new BaseMageClass();
			}else if (isWarriorClass){
				newPlayer.PlayerClass = new BaseWarriorClass();
			}
			newPlayer.PlayerLevel = 1;
			newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
			newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
			newPlayer.Strength =  newPlayer.PlayerClass.Strength;
			newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
			newPlayer.PlayerName = playerName; 
			StoreNewPlayerInfo();
			SaveInformation.SaveAllInformation();
			Debug.Log("Player Name: " + newPlayer.PlayerName);
			Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
			Debug.Log("Player Level " + newPlayer.PlayerLevel);
			Debug.Log("Player Strength " + newPlayer.Strength);
			Debug.Log("Player Stamina " + newPlayer.Stamina);
			Debug.Log("Player Endurance " + newPlayer.Endurance);
			Debug.Log("Player Intellect " + newPlayer.Intellect);
		}

		if (GUILayout.Button ("Load")) {
			SceneManager.LoadScene("Test");
		} 
	}

	private void StoreNewPlayerInfo(){
		GameInformation.PlayerName = newPlayer.PlayerName;
		GameInformation.PlayerLevel = newPlayer.PlayerLevel;
		GameInformation.Stamina = newPlayer.Stamina;
		GameInformation.Strength = newPlayer.Strength;
		GameInformation.Endurance = newPlayer.Endurance;
		GameInformation.Intellect = newPlayer.Intellect;

	}
}
