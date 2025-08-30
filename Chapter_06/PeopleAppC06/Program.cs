using LibC06V1.Shared;
using System.Collections;
using static System.Console;
using static LibC06V1.Shared.Person;
using static LibC06V1.Shared.StringExtensions;

static void Harry_Shout(object? sender, EventArgs e)
{
  if (sender is null) return;

  Person p =(Person)sender;
  WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
}
;

Person harry = new() { Name = "Harry" };
Person mary = new() { Name = "Mary" }; 
Person jill = new() { Name = "Jill" };

Person baby01 = mary.ProcreateWith(harry);
baby01.Name = "Gary";

Person baby02 = Person.Procreate(harry, jill);
Person baby03 = harry * mary;

WriteLine($"{harry.Name} has {harry.Children.Count} children."); 
WriteLine($"{mary.Name} has {mary.Children.Count} children."); 
WriteLine($"{jill.Name} has {jill.Children.Count} children."); 
WriteLine(
  format: "{0}'s first child is named \"{1}\".",
  arg0: harry.Name,
  arg1: harry.Children[0].Name);
WriteLine();

string s1 = "Hello "; 
string s2 = "World!";
string s3 = string.Concat(s1, s2); 
WriteLine(s3);
WriteLine();

WriteLine($"5! is {Person.Factorial(5)}");
WriteLine();

var person = new Person() { Name = "Tim" };
DelegateWithMatchingSignature d = new(person.MethodIWantToCall);

int result = d("hello");
WriteLine($"result is {result}");

harry.Shout += Harry_Shout;
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2;
WriteLine(format: "Key {0} has value: {1}", arg0: key, arg1: lookupObject[key]);
WriteLine(format: "Key {0} has value: {1}", arg0: harry, arg1: lookupObject[harry]);

Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");

key = 3;
WriteLine(format: "Key {0} has value: {1}", arg0: key, arg1: lookupIntString[key]);
WriteLine();

Person[] people =
{
  new() { Name = "Simon" },
  new() { Name = "Jenny" },
  new() { Name = "Adam" },
  new() { Name = "Richard" }
};

WriteLine("Initial list of people:");

foreach (Person p in people)
{
  WriteLine($"  {p.Name}");
}

WriteLine("Use Person's IComparable implementation to sort:");

Array.Sort(people);

foreach (Person p in people)
{
  WriteLine($"  {p.Name}");
}

WriteLine();

WriteLine("Use PersonComparer's IComparer implementation to sort:");

Array.Sort(people, new PersonComparer());

foreach (Person p in people)
{
  WriteLine($"  {p.Name}");
}

WriteLine();

DisplacementVector dv1 = new(3, 5); 
DisplacementVector dv2 = new(-2, 7); 
DisplacementVector dv3 = dv1 + dv2;
WriteLine($"Vectors ({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

WriteLine();

Employee john = new()
{
  Name = "John Jones",
  DateOfBirth = new(year: 1990, month: 7, day: 28),
  EmployeeCode = "JJ001",
  HireDate = new(year: 2014, month: 11, day: 23)
};

john.WriteToConsole();
WriteLine($"{john.Name} was hired on {john.HireDate: dd/MM/yy}");
WriteLine(john.ToString());
WriteLine();

Employee aliceInEmployee = new()
{
  Name = "Alice",
  EmployeeCode = "AA123"
};

Person aliceInPerson = aliceInEmployee; 
aliceInEmployee.WriteToConsole(); 
aliceInPerson.WriteToConsole(); 
WriteLine(aliceInEmployee.ToString());
WriteLine(aliceInPerson.ToString());
WriteLine();

// if (aliceInPerson is Employee)
// {
//   WriteLine($"{nameof(aliceInPerson)} IS an Employee");
//   Employee explicitAlice = (Employee)aliceInPerson;
// }

if (aliceInPerson is Employee explicitAlice)
{
  WriteLine($"{nameof(aliceInPerson)} IS an Employee");
}

Employee? aliceAsEmployee = aliceInPerson as Employee;

if (aliceAsEmployee != null)
{
  WriteLine($"{nameof(aliceInPerson)} AS an Employee");
}

try
{
  john.TimeTravel(when: new(year: 1999, month: 12, day: 31));
  john.TimeTravel(when: new DateTime(1950, 12, 25));
}
catch (PersonException ex)
{
  WriteLine(ex.Message);
}

string email1 = "pamela@test.com";
string email2 = "ian&test.com";

WriteLine("{0} is a valid e-mail address: {1}", 
  arg0: email1,
  arg1: email1.IsValidEmail());

WriteLine("{0} is a valid e-mail address: {1}",
  arg0: email2,
  arg1: email2.IsValidEmail());
WriteLine();


