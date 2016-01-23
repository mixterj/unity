using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseEquipment : BaseStatItem {

	public enum EquipmentTypes {
		HELM,
		CHEST,
		SHOULDER,
		LEGS,
		FEET,
		NECK,
		HANDS,
		RING
	}

	private EquipmentTypes equipmentType;
	private int spellEffectID; // Add this later

	public EquipmentTypes EquipmentType {
		get{return equipmentType;}
		set{equipmentType = value;}
	}

	public int SpellEffectID {
		get{ return spellEffectID;}
		set{spellEffectID = value;}
	}
}
