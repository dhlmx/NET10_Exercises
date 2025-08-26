namespace LibModernV1.Shared;

public record ImmutableVehicle
{
  public int Wheels { get; init; }
  public string? Color { get; init; }
  public string? Brand { get; init; }
}

public record InmutableAnimal
{
  public string? Name { get; init; }
  public string? Species { get; init; }

  public InmutableAnimal(string name, string species) =>
    (Name, Species) = (name, species);

  public void Deconstruct(out string? name, out string? species) =>
    (name, species) = (Name, Species);

  public record InmutableAnimalWithPositional(string Name, string Species);
}