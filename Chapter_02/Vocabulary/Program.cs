using System.Reflection;
using System.Net.Http;

System.Data.DataSet ds = new System.Data.DataSet();
HttpClient hc = new HttpClient();
Assembly? assembly = Assembly.GetEntryAssembly();

double heightInMeters = 1.88;
string egiptianHieroglyph = "\uD80C\uDC01"; // Verbatim strings: U+13001 is the code point for the Egyptian hieroglyph "𓀁"
string fullNameWithTabSeparator = "Bob\t\nSmith";
string filePath = @"C:\televisions\sony\bravia.txt";

char letterA = 'A'; // assigning literal characters
char digit1 = '1';
char symbolDollar = '$';

string firstName = "Bob"; // assigning literal strings
string lastName = "Smith";
string phoneNumber = "(215) 555-4256";


if (assembly == null)
{
    return;
}

foreach (AssemblyName name in assembly.GetReferencedAssemblies())
{
    Assembly a = Assembly.Load(name);
    int methodCount = 0;

    foreach (TypeInfo t in a.DefinedTypes)
    {
        methodCount += t.GetMethods().Count();
    }

    Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly",
                      arg0: a.DefinedTypes.Count(),
                      arg1: methodCount,
                      arg2: name.Name);
}

Console.WriteLine($"The variable {nameof(heightInMeters)} has the value {heightInMeters:N2}.");
Console.WriteLine($"The variable {nameof(egiptianHieroglyph)} has the value {egiptianHieroglyph}.");
Console.WriteLine($"The variable {nameof(fullNameWithTabSeparator)} has the value {fullNameWithTabSeparator}.");
Console.WriteLine($"The variable {nameof(filePath)} has the value {filePath}.");

