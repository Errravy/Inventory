using System;
public class Equipment : ItemObject
{
    public int atk;
    public int def;
    public Equipment(string name,int getAtk,int getDef)
    {
        itemName = name;
        atk = getAtk;
        def = getDef;
        item = ItemType.Equipment;
    }

}