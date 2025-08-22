using System.Xml;
using Variables;

object height = 1.88; // storing a double in an object 
object name = "Amir"; // storing a string in an object
Console.WriteLine($"{name} is {height} metres tall.");

// int length1 = name.Length; // gives compile error!
int length2 = ((string)name).Length; // tell compiler it is a string
Console.WriteLine($"{name} has {length2} characters.");

dynamic something = "Ahmed";
// something = 12;
// something = new[] { 3, 5, 7 };

Console.WriteLine($"Length is {something.Length}");

int population = 66_000_000; // 66 million in UK
double weight = 1.88; // in kilograms
decimal price = 4.99M; // in pounds sterling
string fruit = "Apples"; // strings use double-quotes
char letter = 'Z'; // chars use single-quotes
bool happy = true; // Booleans have value of true or false

var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();
XmlDocument xml3 = new();

var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

Person kim = new()
{
  BirthDate = new(1967, 12, 26)
};

Console.WriteLine($"default(int) = {default(int)}"); 
Console.WriteLine($"default(bool) = {default(bool)}"); 
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"number has been set to: {number}");

number = default;
Console.WriteLine($"number has been reset to its default: {number}");

string[] names; // can reference any size array of strings
// allocating memory for four strings in an array
names = new string[4];
// storing items at index positions
names[0] = "Kate";
names[1] = "Jack"; 
names[2] = "Rebecca"; 
names[3] = "Tom";
// looping through the names
for (int i = 0; i < names.Length; i++)
{
  // output the item at index position i
  Console.WriteLine(names[i]);
}

string[] names2 = new[] { "Kate", "Jack", "Rebecca", "Tom" };



