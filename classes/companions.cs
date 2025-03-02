namespace ConsoleRPG.classes;

public class Companion(string name, int xp, string level, List<Trait> traits, List<Ability> abilities)
{
  public string Name { get; set; } = name;
  public int Xp { get; set; } = xp;
  public string Level { get; set; } = level;
  public List<Trait> Traits { get; set; } = new();
  public List<Stat> Stats { get; set; } = new();
  public List<Ability> Abilities { get; set; } = new();
}

public class CompanionsList
{
  public List<Companion> Companions =
  [
  ];
}