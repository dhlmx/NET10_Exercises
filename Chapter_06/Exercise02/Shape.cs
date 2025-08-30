namespace Exercise02;

public class Shape
{
  protected readonly double _height;
  protected readonly double _width;

  protected Shape(double height)
  {
    _height = height;
    _width  = height;
  }

  protected Shape(double height, double width)
  {
    _height = height;
    _width = width;
  }
}