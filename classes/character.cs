namespace ConsoleRPG;

public class Character(
  string name,
  int money,
  List<Item> inventory,
  List<Companion> companions,
  List<Achievement> achievements,
  List<Ability> abilities)
{
  public required string Name { get; set; }
  public required int Money { get; set; } = 0;
  public List<Item> Inventory { get; set; } = new();
  public List<Companion> Companions { get; set; } = new();
  public List<Achievement> Achievements { get; set; } = new();
  public List<Ability> Abilities { get; set; } = new();
}