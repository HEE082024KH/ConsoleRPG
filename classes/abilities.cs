namespace ConsoleRPG.classes;

public class Ability(string name, string description, string type, int levelReq, int uses, int power, int accuracy)
{
  public string Name { get; set; } = name;
  public string Description { get; set; } = description;
  public string Type { get; set; } = type;
  public int LevelReq { get; set; } = levelReq;
  public int Uses { get; set; } = uses;
  public int Power { get; set; } = power;
  public int Accuracy { get; set; } = accuracy;
}

public class AbilitiesList
{
  public List<Ability> Abilities =
  [
    // Fire
    new("Fire Spit", "Spits small clusters of fire.", "Fire", 5, 35, 20, 100),
    new("Scorch", "A burst of fire.", "Fire", 12, 30, 30, 100),
    new("Fire barrier", "Surrounds the user with a protective barrier of fire.", "Fire", 16, 20, 30, 100),
    new("Fireball", "Hurls a ball of scorching fire.", "Fire", 20, 25, 40, 100),
    new("Cauterize", "Cauterizes wounds using fire.", "Fire", 30, 15, 45, 100),
    new("Searing Bite", "A bite ignited by searing embers.", "Fire", 33, 20, 55, 95),
    new("Flame cannon", "Shoots a volley of fire and lava.", "Fire", 41, 15, 70, 90),
    new("Fire Blast", "Blasts the target with blazing fire.", "Fire", 46, 10, 80, 100),
    new("Fire Wall", "Conjures a wall of fire protecting the user.", "Fire", 47, 10, 90, 95),
    new("Blaze Tornado", "Hurls a tornado of scorching hot fire.", "Fire", 50, 10, 100, 95),
    new("Molten Eruption", "An eruption of molten lava exploding with velocity.", "Fire", 57, 5, 150, 85),
    new("Inferno", "Fire surrounds the user as a blast wave erupts.", "Fire", 65, 5, 120, 100),

    // Frost
    new("Rime", "", "Frost", 5, 35, 20, 100),
    new("Ice Lance", "", "Frost", 11, 30, 35, 100),
    new("Frostbolt", "Shoots a projectile of frost and cold", "Frost", 15, 20, 50, 100),
    new("Chill", "Chills the target, increasing Frost damage taken", "Frost", 19, 20, 50, 90),
    new("", "", "Frost", 29, 0, 0, 0),
    new("", "", "Frost", 32, 0, 0, 0),
    new("", "", "Frost", 39, 0, 0, 0),
    new("", "", "Frost", 45, 0, 0, 0),
    new("", "", "Frost", 51, 0, 0, 0),
    new("", "", "Frost", 58, 0, 0, 0),
    new("", "", "Frost", 64, 0, 0, 0)

    // Water, Shadow, Physical, Electric, Ground, Light/Holy
  ];
}