namespace ConsoleRPG.classes;

public class Stat(string name, string value)
{
  public string Name { get; set; }
  public string Value { get; set; }
}

public class StatsList
{
  public List<Stat> Stats { get; set; } = new();
}