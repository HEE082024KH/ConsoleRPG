public class Item
{
  public string Name { get; set; }
  public int Amount { get; set; }
  public int BuyValue { get; set; }
  public int SellValue { get; set; }
}

public class ItemsAndInventory
{
  public List<Item> Inventory { get; set; } = [];
}