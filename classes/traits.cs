namespace ConsoleRPG.classes;

public class Trait(string name, string description)
{
  public required string Name { get; set; } = name;
  public string Description { get; set; } = description;
}

public class TraitsList
{
  public List<Trait> Traits =
  [
  ];
}