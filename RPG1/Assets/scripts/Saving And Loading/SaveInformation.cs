using UnityEngine;
using System.Collections;

public class SaveInformation {

	public static void SaveAllInformation() {
		PlayerPrefs.SetInt ("PLAYERLEVEL", GameInformation.PlayerLevel);
		PlayerPrefs.SetString ("PLAYERNAME", GameInformation.PlayerName);
		PlayerPrefs.SetInt ("STAMINA", GameInformation.Stamina);
		PlayerPrefs.SetInt ("STRENGTH", GameInformation.Strength);
		PlayerPrefs.SetInt ("ENDURANCE", GameInformation.Endurance);
		PlayerPrefs.SetInt ("INTELLECT", GameInformation.Intellect);

		if (GameInformation.EquipmentOne != null) {
			PPSerialization.Save ("EQUIPMENT1", GameInformation.EquipmentOne);
		}
		Debug.Log ("Saved All Information");
	}
}
