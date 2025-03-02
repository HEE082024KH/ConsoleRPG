namespace ConsoleRPG.classes;

public class Ability(string name, string description, string type, int levelReq, int uses, int value)
{
  public string Name { get; set; } = name;
  public string Description { get; set; } = description;
  public string Type { get; set; } = type;
  public int LevelReq { get; set; } = levelReq;
  public int Uses { get; set; } = uses;
  public int Value { get; set; } = value;
}

public class AbilitiesList
{
  public List<Ability> Abilities =
  [
    // Fire
    new("Burn", "Attempts to burn the target.", "Fire", 5, 35, 5),
    new("Fire Spit", "Spits small clusters of fire", "Fire", 12, 30, 10),
    new("Fire barrier", "Surrounds the user with a protective barrier of fire", "Fire", 17, 20, 0),
    new("Fireball", "Hurls a ball of scorching fire", "Fire", 20, 25, 15),
    new("Cauterize", "Cauterizes wounds using fire", "Fire", 30, 10, 20),
    new("Searing Bite", "A bite ignited by searing embers", "Fire", 33, 20, 28),
    new("Molten Tornado", "Hurls a tornado of molten lava", "Fire", 41, 15, 40),
    new("", "", "Fire", 50, 10, 0),
    new("", "", "Fire", 65, 5, 0),
    // Fire Wall, Explosion
    // Plasma, Flame, Molten, Tornado, Blaze, Heat, Flare, Searing

    // Frost
    new("Frostbolt", "Shoots a projectile of frost and cold", "Frost", 13, 20, 15)
  ];
}