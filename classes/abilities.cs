namespace ConsoleRPG.classes;

public class Ability(string name, string description, string type, int levelReq, int uses, int value, int accuracy)
{
  public string Name { get; set; } = name;
  public string Description { get; set; } = description;
  public string Type { get; set; } = type;
  public int LevelReq { get; set; } = levelReq;
  public int Uses { get; set; } = uses;
  public int Value { get; set; } = value;
  public int Accuracy { get; set; } = accuracy;
}

public class AbilitiesList
{
  public List<Ability> Abilities =
  [
    // Fire
    new("Fire Spit", "Spits small clusters of fire.", "Fire", 5, 35, 5, 100),
    new("", "", "Fire", 12, 30, 10, 100),
    new("Fire barrier", "Surrounds the user with a protective barrier of fire.", "Fire", 16, 20, 10, 100),
    new("Fireball", "Hurls a ball of scorching fire.", "Fire", 20, 25, 15, 100),
    new("Cauterize", "Cauterizes wounds using fire.", "Fire", 30, 15, 30, 100),
    new("Searing Bite", "A bite ignited by searing embers.", "Fire", 33, 20, 28, 95),
    new("Blaze Tornado", "Hurls a tornado of scorching hot fire.", "Fire", 41, 15, 40, 90),
    new("Fire Wall", "Conjures a wall of fire protecting the user.", "Fire", 47, 10, 50, 95),
    new("Molten Eruption", "An eruption of molten lava exploding with velocity.", "Fire", 50, 10, 55, 85),
    new("", "", "Fire", 57, 0, 0, 0),
    new("Inferno", "Fire surrounds the user as a blast wave erupts.", "Fire", 65, 5, 80, 80),
    // Plasma, Flame, Molten, Tornado, Blaze, Heat, Flare, Searing

    // Frost
    new("Rime", "", "Frost", 5, 35, 5, 100),
    new("", "", "Frost", 11, 0, 0, 0),
    new("Frostbolt", "Shoots a projectile of frost and cold", "Frost", 15, 20, 15, 100),
    new("", "", "Frost", 19, 0, 0, 0),
    new("", "", "Frost", 29, 0, 0, 0),
    new("", "", "Frost", 32, 0, 0, 0),
    new("", "", "Frost", 39, 0, 0, 0),
    new("", "", "Frost", 45, 0, 0, 0),
    new("", "", "Frost", 51, 0, 0, 0),
    new("", "", "Frost", 58, 0, 0, 0),
    new("", "", "Frost", 64, 0, 0, 0),
  ];
}