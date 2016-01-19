using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem {   // BaseWeapon <- BaseStatItem <- BaseItem
	public enum WeaponTypes {
		SWORD,
		STAFF,
		DAGGER,
		BOW,
		POLEARM,
		SHIELD
	}
	private WeaponTypes weaponType;
	private int spellEffectID; // Add this later

	public WeaponTypes WeaponType{
		get{return weaponType;}
		set{weaponType = value;}
	}

	public int SpellEffectID {
		get{ return spellEffectID;}
		set{spellEffectID = value;}
	}

}
