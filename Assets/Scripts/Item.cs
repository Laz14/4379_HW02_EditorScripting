using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum Rarity { Common, Rare, Epic, Legendary }
[System.Serializable]
public enum Slot { Head, Chest, Arms, Legs }

[System.Serializable]
public class Item
{
    public string name;
    public int value;
    public Rarity rarity;
    public Slot slot;

    public Item(string name, int value, Rarity rarity, Slot slot)
    {
        this.name = name;
        this.value = value;
        this.rarity = rarity;
        this.slot = slot;
    }
}
