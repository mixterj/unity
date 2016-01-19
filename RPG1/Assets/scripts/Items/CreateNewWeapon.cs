using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

	private BaseWeapon newWeapon;

	void Start() {
		CreateWeapon();
		Debug.Log (newWeapon.ItemName);
		Debug.Log (newWeapon.ItemDsecription);
		Debug.Log (newWeapon.ItemID.ToString());
		Debug.Log (newWeapon.WeaponType.ToString());
		Debug.Log (newWeapon.Stamina.ToString());
		Debug.Log (newWeapon.Strength.ToString());
	}

	// create array to actually have names - do this later
	// private string[] weaponNames = new string[6] {"Weapon of Greatness"} 
	public void CreateWeapon() {

		newWeapon = new BaseWeapon();
		// assign name to weapon
		newWeapon.ItemName = "W" + Random.Range(1, 101);
		// create weapon description
		newWeapon.ItemDsecription = "This is a new weapon.";
		// stats
		newWeapon.Endurance = Random.Range(1, 11);
		newWeapon.Stamina = Random.Range(1, 11);
		newWeapon.Strength = Random.Range(1, 11);
		newWeapon.Intellect = Random.Range(1, 11);
		//weapon ID
		newWeapon.ItemID = Random.Range(1, 101);
		// choose type of weapon
		ChooseWeaponType();
		// spell effect ID
		newWeapon.SpellEffectID = Random.Range(1, 101);

	}

	private void ChooseWeaponType() {
		int randomTemp = Random.Range (1, 7);
		if (randomTemp == 1) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
		}else if(randomTemp == 2) {
				newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
		}else if(randomTemp == 3) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD;
		}else if(randomTemp == 4) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
		}else if(randomTemp == 5) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
		}else if(randomTemp == 6) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.POLEARM;
		}
	}
}
