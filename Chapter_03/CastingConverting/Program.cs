using static System.Console;
using static System.Convert;

int a = 10;
double b = a; // an int can be safely cast into a double
WriteLine(b);
WriteLine();

double c = 9.8;
int d = (int)c; // compiler gives an error for this line
WriteLine(d);
WriteLine();

long e = 10; 
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");
WriteLine();

e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");
WriteLine();

e = 5_000_000_000;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");
WriteLine();

double g = 9.8;
int h = ToInt32(g); // a method of System.Convert
WriteLine($"g is {g} and h is {h}");
WriteLine();

double[] doubles = [ 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 ];

foreach (double n in doubles)
{
  WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}
WriteLine();

foreach (double n in doubles)
{
  WriteLine(format:
    "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
    arg0: n,
    arg1: Math.Round(value: n, digits: 0,
            mode: MidpointRounding.AwayFromZero));
}
WriteLine();

int number = 12; 
WriteLine(number.ToString());

bool boolean = true; 
WriteLine(boolean.ToString());

DateTime now = DateTime.Now; 
WriteLine(now.ToString());

object me = new();
WriteLine(me.ToString());
WriteLine();

// allocate array of 128 bytes
byte[] binaryObject = new byte[128];

// populate array with random bytes
(new Random()).NextBytes(binaryObject);

WriteLine("Binary Object as bytes:");
for(int index = 0; index < binaryObject.Length; index++)
{
  Write($"{binaryObject[index]:X} ");
}
WriteLine();

// convert to Base64 string and output as text
string encoded = ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64: {encoded}");
WriteLine();

int age = int.Parse("27");
DateTime birthday = DateTime.Parse("4 July 1980");
WriteLine($"I was born {age} years ago."); 
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}.");
WriteLine();

Write("How many eggs are there? ");

string? input = ReadLine(); // or use "12" in notebook

if (int.TryParse(input, out int count))
{
  WriteLine($"There are {count} eggs.");
}
else
{
  WriteLine("I could not parse the input.");
}
WriteLine();
