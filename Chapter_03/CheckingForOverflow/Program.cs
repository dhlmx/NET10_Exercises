using static System.Console;

try
{
  checked
  {
    int x = int.MaxValue - 1;
    WriteLine($"Initial value: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
  }
}
catch (OverflowException)
{
  WriteLine("Arithmetic operation resulted in an overflow.");
}
WriteLine();

unchecked
{
  int y = int.MaxValue + 1; 
  WriteLine($"Initial value: {y}"); 
  y--;
  WriteLine($"After decrementing: {y}"); 
  y--;
  WriteLine($"After decrementing: {y}");
}
WriteLine();

for (; true;)
{
  WriteLine("Processing an infinte loop. Press Ctrl+C to end.");
};
