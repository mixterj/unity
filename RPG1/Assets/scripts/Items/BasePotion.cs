using UnityEngine;
using System.Collections;

public class BasePotion : BaseStatItem {
	public enum PotionTypes {
		HEALTH,
		ENTERGY,
		STRENGTH,
		ENDURANCE,
		INTELLECT,
		VITALITY,
		SPEED
	}

	private PotionTypes potionTypes;
	private int spellEffectID; // Add this later

	public PotionTypes PotionType {
		get{return potionTypes;}
		set{potionTypes = value;}
	}

	public int SpellEffectID {
		get{ return spellEffectID;}
		set{spellEffectID = value;}
	}
}
