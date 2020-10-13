using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>(1);

    public void AddNew()
    {
        items.Add(new Item("TestItem", 500, Rarity.Epic, Slot.Chest));
    }

    public void Remove(int index)
    {
        items.RemoveAt(index);
    }
}
