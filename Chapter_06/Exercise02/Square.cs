namespace Exercise02;

public class Square(double side) : Shape(side)
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
    get => base._height * 4;
  }
}
