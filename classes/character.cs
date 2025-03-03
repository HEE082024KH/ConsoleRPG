namespace ConsoleRPG.classes;

public class Character(
  string name,
  List<Item> inventory,
  List<Companion> companions,
  List<Achievement> achievements,
  int xp = 0,
  int level = 1,
  int money = 500)
{
  public required string Name { get; set; } = name;
  public required int Money { get; set; } = money;
  public required int Level { get; set; } = level;
  public int Xp { get; set; } = xp;
  public List<Item> Inventory { get; set; } = inventory;
  public List<Companion> Companions { get; set; } = companions;
  public List<Achievement> Achievements { get; set; } = achievements;
}