namespace LibC06V1.Shared;

public record struct DisplacementVector(int initialX, int initialY)
{
  public int X = initialX;
  public int Y = initialY;

  public static DisplacementVector operator +(DisplacementVector vector1, DisplacementVector vector2)
  {
    return new(vector1.X + vector2.X, vector1.Y + vector2.Y);
  }
}
