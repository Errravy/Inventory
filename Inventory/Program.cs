using System;
public class Program
{
    public static void Main()
    {
        Consumables pot1 = new Consumables("Health Potion",100);
        Equipment shield1 = new Equipment("Rounded Stone",0,50);
        Equipment sword1 = new Equipment("Stick Of Dark",1000,0);
        Bag playerBag = new Bag();
        playerBag.AddItem(shield1,1);
        playerBag.AddItem(pot1,1);
        playerBag.AddItem(sword1,1);
        playerBag.AddItem(shield1,1);
        playerBag.AddItem(pot1,1);
        playerBag.AddItem(pot1,1);
        foreach(InventorySlot i in playerBag.slots)
        {
            Console.WriteLine("Item : {0} || Jumlah: {1}",i.item.itemName,i.amount);
        }
    }
}