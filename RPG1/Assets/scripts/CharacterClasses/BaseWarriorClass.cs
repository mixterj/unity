using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharacterClass {
	public BaseWarriorClass(){
		CharacterClassName = "Warrior";
		CharacterClassDescription = "A strong and brave fighter from the North";
		Stamina = 12;
		Strength = 15;
		Endurance = 13;
		Intellect = 5;
	}
}
