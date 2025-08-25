using LibV1;
using LibV1.Shared;
using static System.Console;

Person bob = new()
{
  Name = "Bob Smith",
  DateOfBirth = new DateTime(year: 1965, month: 12, day: 22),
  FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia,
  BucketList = WondersOfTheAncientWorld.GreatPyramidOfGiza | WondersOfTheAncientWorld.HangingGardensOfBabylon,
  Children = new List<Person>()
};

bob.Children.Add(
  new Person()
  {
    Name = "Alfred Vazquez",
    DateOfBirth = new DateTime(year: 1980, month: 12, day: 10),
    FavoriteAncientWonder = WondersOfTheAncientWorld.ColossusOfRhodes
  }
);

bob.Children.Add(
  new Person()
  {
    Name = "Zoe"
  }
);

WriteLine($"{bob.Name} was born on {bob.DateOfBirth:dddd, d MMMM yyyy}");
WriteLine($"{bob.Name}'s favourite wonder is {bob.FavoriteAncientWonder}. Its integer is {(int)bob.FavoriteAncientWonder}.");
WriteLine($"{bob.Name} has {bob.Children.Count} children:");

foreach (Person p in bob.Children)
{
  WriteLine($"{p.Name}");
}

bob.WriteToConsole(); 
WriteLine(bob.GetOrigin());
WriteLine();

Person alice = new()
{
  Name = "Alice Jones",
  DateOfBirth = new(1998, 3, 7),
  FavoriteAncientWonder = WondersOfTheAncientWorld.HangingGardensOfBabylon
};

WriteLine($"{alice.Name} was born on {alice.DateOfBirth:dddd, d MMMM yyyy}");
WriteLine($"{alice.Name}'s favourite wonder is {alice.FavoriteAncientWonder}. Its integer is {(int)alice.FavoriteAncientWonder}.");
WriteLine();

bob.BucketList =
  WondersOfTheAncientWorld.HangingGardensOfBabylon
  | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
WriteLine();

BankAccount.InterestRate = 0.012M;
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine($"{jonesAccount.AccountName} earned {jonesAccount.Balance * BankAccount.InterestRate:C} interest.");
WriteLine();

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine($"{gerrierAccount.AccountName} earned {gerrierAccount.Balance * BankAccount.InterestRate:C} interest.");
WriteLine();

WriteLine($"{bob.Name} is a {Person.Species}");
WriteLine();

WriteLine($"{bob.Name} was born on {bob.HomePlanet}");
WriteLine();

Person blankPerson = new();
WriteLine(
  $"{blankPerson.Name} of {blankPerson.HomePlanet} was created at {blankPerson.Instantiated:hh:mm:ss} on a {blankPerson.Instantiated:dddd}."
);
WriteLine();

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
WriteLine(format:
  "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
  arg0: gunny.Name,
  arg1: gunny.HomePlanet,
  arg2: gunny.Instantiated);
WriteLine();

(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");
WriteLine();

var fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");
WriteLine();

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");
var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");

// Deconstruction
// (string TheName, int TheNumber) tupleWithNamedFields = bob.GetNamedFruit();
// tupleWithNamedFields.TheName;
// tupleWithNamedFields.TheNumber;
// deconstruct return value into two separate variables
// (string name, int number) = GetNamedFruit();

var (fruitName, fruitNumber) = bob.GetNamedFruit();
WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");
WriteLine();

// Deconstructing a Person
var (name1, dob1) = bob;
WriteLine($"Deconstructed: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");
WriteLine();

WriteLine(bob.SayHello()); 
WriteLine(bob.SayHello("Emily"));
WriteLine();

WriteLine(bob.OptionalParameters());
WriteLine(bob.OptionalParameters("Jump!", 98.5));
WriteLine(bob.OptionalParameters(number: 52.7, command: "Hide!"));
WriteLine(bob.OptionalParameters("Poke!", active: false));
WriteLine();

int a = 10; 
int b = 20; 
int c = 30;
WriteLine($"Before: a = {a}, b = {b}, c = {c}"); 
bob.PassingParameters(a, ref b, out c); 
WriteLine($"After: a = {a}, b = {b}, c = {c}");
WriteLine();

int d = 10; 
int e = 20;
WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!");
// simplified C# 7.0 or later syntax for the out parameter 
bob.PassingParameters(d, ref e, out int f); 
WriteLine($"After: d = {d}, e = {e}, f = {f}");
WriteLine();

Person sam = new()
{
  Name = "Sam",
  DateOfBirth = new(year: 1972, month: 1, day: 27)
};
WriteLine(sam.Origin); 
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}."); 
sam.FavoritePrimaryColor = "Red";
WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");

sam.Children.Add(new() { Name = "Charlie" });
sam.Children.Add(new() { Name = "Ella" });
WriteLine($"Sam's first child is {sam.Children[0].Name}"); 
WriteLine($"Sam's second child is {sam.Children[1].Name}");
WriteLine($"Sam's first child is {sam[0].Name}"); 
WriteLine($"Sam's second child is {sam[1].Name}");
WriteLine();

Book book = new()
{
  ISBN = "978-0-13-419044-0",
  Title = "C# 10 and .NET 6 - Modern Cross-Platform Development"
};
