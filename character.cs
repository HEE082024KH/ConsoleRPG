namespace ConsoleRPG;

public class Character
{
  public required string Name { get; set; }
  public required int Money { get; set; } = 0;
  public List<Item> Inventory { get; set; } = new();
  public List<Companion> Party { get; set; } = new();
  public List<Achievement> Achievements { get; set; } = new();
  public List<Ability> Abilities { get; set; } = new();
}