namespace ConsoleRPG.classes;

public class Companion(string name, string level, List<Trait> traits, List<Ability> abilities)
{
  public string Name { get; set; } = name;
  public string Level { get; set; } = level;
  public List<Trait> Traits { get; set; } = new();
  public List<Ability> Abilities { get; set; } = new();
}

public class CompanionsList
{
  public List<Companion> Companions =
  [
  ];
}