namespace ConsoleRPG.classes;

public class Ability(string name, string description, string type, int uses, int dmg)
{
  public string Name { get; set; } = name;
  public string Description { get; set; } = description;
  public string Type { get; set; } = type;
  public int Uses { get; set; } = uses;
  public int Dmg { get; set; } = dmg;
}

public class AbilitiesList
{
  public List<Ability> Abilities =
  [
  ];
}