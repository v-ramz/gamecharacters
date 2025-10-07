public class Dk : Character
{
  public string? Species { get; set; }

  public override string Display()
  {
    return $"Id: {Id}\nName: {Name}\nDescription: {Description}\nSpecies: {Species}\n";
  }
}