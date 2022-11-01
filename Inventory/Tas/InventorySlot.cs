public class InventorySlot
{
    public int amount;
    public ItemObject item;
    public InventorySlot(ItemObject getItem,int getAmount)
    {
        item = getItem;
        amount = getAmount;
    }
    public void AddItem(int getAmount)
    {
        amount += getAmount;
    }
}