using System.Collections;
using static System.Console;

int x = 0;
while (x < 10)
{
  WriteLine(x);
  x++;
}

string? password;

do
{
  Write("Enter your password: ");
  password = ReadLine();
}
while (password != "Pa$$w0rd");

WriteLine("Correct!");

for (int i = 0; i < 10; i++)
{
  WriteLine(i);
}

string[] names = { "Adam", "Barry", "Charlie" };

foreach (string name in names)
{
  WriteLine($"{name} has {name.Length} characters.");
}

IEnumerator e = names.GetEnumerator();

while (e.MoveNext())
{
  string name = (string)e.Current; // Current is read-only!
  WriteLine($"{name} has {name.Length} characters.");
}

