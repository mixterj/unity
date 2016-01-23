using UnityEngine;
using System.Collections;

public class LoadInformation : MonoBehaviour {
	public static void LoadAllInformation(){
		GameInformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
		GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
		GameInformation.Stamina = PlayerPrefs.GetInt("STAMINA");
		GameInformation.Strength = PlayerPrefs.GetInt("STRENGTH");
		GameInformation.Endurance = PlayerPrefs.GetInt("ENDURANCE");
		GameInformation.Intellect = PlayerPrefs.GetInt("INTELLECT");
		if (PlayerPrefs.GetString ("EQUIPMENT1") != null) {
			GameInformation.EquipmentOne = (BaseEquipment) PPSerialization.Load ("EQUIPMENT1");
		}
	}
}
