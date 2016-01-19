using UnityEngine;
using System.Collections;

public class BaseItem {
	private string itemName;
	private string itemDsecription;
	private int itemID;
	public enum ItemTypes {
		EQUIPMENT,
		WEAPON,
		SCROLL,
		POTION,
		CHEST
	}
	private ItemTypes itemType;

	public string ItemName{
		get{return itemName;}
		set{itemName = value;}
	}
	public string ItemDsecription{
		get{return itemDsecription;}
		set{itemDsecription = value;}
	}
	public int ItemID{
		get{return itemID;}
		set{itemID = value;}
	}
	public ItemTypes ItemType{
		get{return itemType;}
		set{itemType = value;}
	}
}
