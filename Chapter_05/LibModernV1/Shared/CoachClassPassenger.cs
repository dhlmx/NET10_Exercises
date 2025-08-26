namespace LibModernV1.Shared;

public class CoachClassPassenger
{
  public double CarryOnKg { get; set; }
  
  public override string ToString()
  {
    return $"Coach Class with {CarryOnKg:N2} kg carry-on";
  }
}
