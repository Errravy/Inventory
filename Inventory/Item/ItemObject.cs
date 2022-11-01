using System;

public enum ItemType
{
    Consumables,
    Equipment,
}
public class ItemObject
{
    public int id;
    public ItemType item;
    public string itemName = "";
}