using System;
public class Consumables : ItemObject
{
    public int healValue;
    public Consumables(string name,int value)
    {
        itemName = name;
        healValue = value;
        item = ItemType.Consumables;
    }

}