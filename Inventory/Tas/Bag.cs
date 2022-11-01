using System;
using System.Collections.Generic;

public class Bag
{
    public int maxCapacity;
    public List<InventorySlot> slots = new List<InventorySlot>();
    public void AddItem(ItemObject getItem,int getAmount)
    {
        bool hasItem = false;
        for(int i = 0; i < slots.Count; i ++)
        {
            if(slots[i].item == getItem && getItem.item != ItemType.Equipment )
            {
                slots[i].AddItem(getAmount);
                hasItem = true;
                break;
            }
        }
        if(!hasItem)
        {
            slots.Add(new InventorySlot(getItem,getAmount));
        }
    }
}

