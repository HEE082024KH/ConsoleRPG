public class Item(string name, int bValue, int sValue = 0, int amount = 0, bool exist = false, bool trade = false)
{
  public string Name { get; } = name;
  public int Amount { get; set; } = amount;
  public int BuyValue { get; set; } = bValue;
  public int SellValue { get; set; } = sValue;
  public bool Exist { get; set; } = exist;
  public bool Trade { get; } = trade;
}

public class ItemsAndInventory
{
  public List<Item> Inventory { get; } =
  [
    new("Money", 0)
  ];
}