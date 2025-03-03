namespace ConsoleRPG.classes;

public class Companion(string name, int xp, int level, List<Trait> traits, List<Ability> abilities)
{
  public string Name { get; set; } = name;
  public int Xp { get; set; } = xp;
  public int Level { get; set; } = level;
  public List<Trait> Traits { get; set; } = [];
  public List<Stat> Stats { get; set; } = [];
  public List<Ability> Abilities { get; set; } = [];
}

public class CompanionsList
{
  public List<Companion> Companions =
  [
  ];
}