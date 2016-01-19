using UnityEngine;
using System.Collections;

public class BaseCharacterClass {
	private  string characterClassName;
	private string characterClassDescription;

	// stats
	private int stamina;
	private int endurance;
	private int strength;
	private int intellect;

	public string CharacterClassName {
		get{return characterClassName;}
		set{characterClassName = value;}
	}
	public string CharacterClassDescription {
		get{return characterClassDescription;}
		set{characterClassDescription = value;}
	}
	public int Stamina {
		get{return stamina;}
		set{stamina = value;}
	}
	public int Endurance {
		get{return endurance;}
		set{endurance = value;}
	}
	public int Strength {
		get{return strength;}
		set{strength = value;}
	}
	public int Intellect {
		get{return intellect;}
		set{intellect = value;}
	}
}
