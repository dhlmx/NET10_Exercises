using Exercise02;
using static System.Console;

Rectangle r = new(height: 3, width: 4.5);
WriteLine($"Rectangle H: {r.Height}, W: {r.Width}, Area: {r.Area}, Perimeter: {r.Perimeter}"); 
Square s = new(side: 5);
WriteLine($"Square H: {s.Height}, W: {s.Width}, Area: {s.Area} Perimeter: {s.Perimeter}");
Circle c = new(radius: 2.5);
WriteLine($"Circle H: {c.Height}, W: {c.Width}, Area: {c.Area}, Perimeter: {c.Perimeter}");
