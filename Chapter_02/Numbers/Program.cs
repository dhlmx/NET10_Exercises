uint natural = 23_000_000;
int integer = -42;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000; // Binary notation for 30,000 in decimal
int hexadecimalNotation = 0x1E8480; // Hexadecimal notation for 30,000 in decimal
float floating = 3.14f;
double doublePrecision = 2.718281828459045;
decimal highPrecision = 1.618033988749895m;

Console.WriteLine("Natural number: " + natural);
Console.WriteLine("Integer: " + integer);
Console.WriteLine("Floating point number: " + floating);
Console.WriteLine("Double precision number: " + doublePrecision);
Console.WriteLine("High precision number: " + highPrecision);

Console.WriteLine("Binary notation: " + binaryNotation);
Console.WriteLine("Hexadecimal notation: " + hexadecimalNotation);

Console.WriteLine("Binary notation (formatted): " + Convert.ToString(binaryNotation, 2).PadLeft(24, '0'));
Console.WriteLine("Hexadecimal notation (formatted): " + hexadecimalNotation.ToString("X6"));

Console.WriteLine("Natural number (with underscores): " + natural.ToString("N0"));
Console.WriteLine("Integer (with underscores): " + integer.ToString("N0"));

Console.WriteLine($"Binary notation == Hexadecimal notation: {binaryNotation == hexadecimalNotation}");

Console.WriteLine();

Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}."); 
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

Console.WriteLine();

Console.WriteLine("Using doubles:"); 
double a = 0.1;
double b = 0.2;
if (a + b >= 0.3 || a + b <= 0.3) // Using >= and <= to avoid precision issues
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
}

Console.WriteLine();

Console.WriteLine("Using decimals:");
decimal c = 0.1M; // M suffix means a decimal literal value
decimal d = 0.2M;
if (c + d == 0.3M)
{
  Console.WriteLine($"{c} + {d} equals {0.3M}");
}
else
{
  Console.WriteLine($"{c} + {d} does NOT equal {0.3M}");
}