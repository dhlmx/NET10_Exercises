namespace Exercise02;

public class Rectangle(double height, double width) : Shape(height, width)
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
    get => base._height * base._width;
  }

  public double Perimeter
  {
    get => 2 * (base._height + base._width);
  }
}
