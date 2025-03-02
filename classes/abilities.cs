namespace ConsoleRPG.classes;

public class Ability(string name, string description, string type, int levelReq, int uses, int dmg)
{
  public string Name { get; set; } = name;
  public string Description { get; set; } = description;
  public string Type { get; set; } = type;
  public int LevelReq { get; set; } = levelReq;
  public int Uses { get; set; } = uses;
  public int Dmg { get; set; } = dmg;
}

public class AbilitiesList
{
  public List<Ability> AbilitiesCompanion =
  [
    new("Burn", "Sets the target ablaze", "Fire", 5, 35, 5),
    new("Fire spit", "A short distance spray of fire", "Fire", 12, 25, 10),
    new("Fireball", "A ball projectile of scorching fire", "Fire", 20, 20, 15),
    new("Frostbolt", "A bolt projectile of frost and cold", "Frost", 13, 20, 15)
  ];
}