using UnityEngine;
using System.Collections;

public class BaseScroll : BaseItem {
	private int spellEffectID; // Add this later

	public int SpellEffectID {
		get{ return spellEffectID;}
		set{spellEffectID = value;}
	}
}
