using static System.Console;

string city = "London";
WriteLine($"{city} is {city.Length} characters long.");
WriteLine($"First char is {city[0]} and third is {city[2]}.");

string cities = "Paris,Tehran,Chennai,Sydney,New York,Medellín"; 
string[] citiesArray = cities.Split(',');
WriteLine($"There are {citiesArray.Length} items in the array.");
foreach (string item in citiesArray)
{
  WriteLine(item);
}
WriteLine();

string fullName = "Alan Jones";
int indexOfTheSpace = fullName.IndexOf(' ');
string firstName = fullName.Substring(startIndex: 0, length: indexOfTheSpace);
string lastName = fullName.Substring(startIndex: indexOfTheSpace + 1);
WriteLine($"Original: {fullName}");
WriteLine($"Swapped: {lastName}, {firstName}");
WriteLine();

string company = "Microsoft";
bool startsWithM = company.StartsWith('M'); 
bool containsN = company.Contains('N');
WriteLine($"Text: {company}");
WriteLine($"Starts with M: {startsWithM}, contains an N: {containsN}");
WriteLine();
