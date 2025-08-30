namespace Exercise02;

public class Circle(double radius) : Shape(radius)
{
  public double Height
  {
    get => base._height;
  }

  public double Width
  {
    get => base._width;
  }

  public double Area
  {
    get => Math.PI * base._height * base._width;
  }

  public double Perimeter
  {
    get => Math.PI * 2 * base._height;
  }
}
