namespace LibModernV1.Shared;

public class FirstClassPassenger
{
  public int AirMiles { get; set; }
  public override string ToString()
  {
    return $"First Class with {AirMiles:N0} air miles";
  }
}
