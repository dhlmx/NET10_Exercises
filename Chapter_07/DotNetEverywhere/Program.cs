using Packt.Shared;
using static System.Console;

WriteLine("I can run everywhere!");
WriteLine($"OS Version is {Environment.OSVersion}.");

if (OperatingSystem.IsMacOS())
{
  WriteLine("I am macOS.");
}
else if (OperatingSystem.IsWindowsVersionAtLeast(major: 10))
{
  WriteLine("I am Windows 10 or 11.");
}
else
{
  WriteLine("I am some other mysterious OS.");
}
WriteLine("Press ENTER to stop me.");
ReadLine();

Write("Enter a color value in hex: "); 
string? hex = ReadLine(); // or "00ffc8"
WriteLine("Is {0} a valid color value? {1}",
  arg0: hex, arg1: hex.IsValidHex());
Write("Enter a XML element: "); 
string? xmlTag = ReadLine(); // or "<h1 class=\"<\" />"
WriteLine("Is {0} a valid XML element? {1}", 
  arg0: xmlTag, arg1: xmlTag.IsValidXmlTag());
Write("Enter a password: "); 
string? password = ReadLine(); // or "secretsauce"
WriteLine("Is {0} a valid password? {1}",
  arg0: password, arg1: password.IsValidPassword());
