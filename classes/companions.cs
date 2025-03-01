public class Companion
{
  public string Name { get; set; }
  public string Level { get; set; }
  public List<Trait> Traits { get; set; } = new();
  public List<Ability> Abilites { get; set; } = new();
}