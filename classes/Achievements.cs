public class Achievement(string name, string description, bool unlock = false)
{
  public string Name { get; set; } = name;
  public string Description { get; set; } = description;
  public bool Unlock { get; set; } = unlock;
}

public class AchievementsList
{
  public List<Achievement> Achievements =
  [
  ];
}