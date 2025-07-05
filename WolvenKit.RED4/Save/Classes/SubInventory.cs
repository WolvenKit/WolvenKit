namespace WolvenKit.RED4.Save.Classes;

public class SubInventory
{
    public ulong InventoryId { get; set; }
    public List<ItemData> Items { get; set; } = new();
}