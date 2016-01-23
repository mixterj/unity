using UnityEngine;
using System.Collections;

public class testSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LoadInformation.LoadAllInformation ();
		Debug.Log("Player Name: " + GameInformation.PlayerName);
		//Debug.Log("Player Class: " +  GameInformation.PlayerName);
		Debug.Log("Player Level " +  GameInformation.PlayerLevel);
 		Debug.Log("Player Strength " +  GameInformation.Strength);
		Debug.Log("Player Stamina " +  GameInformation.Stamina);
		Debug.Log("Player Endurance " +  GameInformation.Endurance);
		Debug.Log("Player Intellect " +  GameInformation.Intellect);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
