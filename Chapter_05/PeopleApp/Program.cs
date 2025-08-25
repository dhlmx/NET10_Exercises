using LibV1;
using LibV1.Shared;
using static System.Console;

BankAccount.InterestRate = 0.012M;
BankAccount bank

Person bob = new()
{
  Name = "Bob Smith",
  DateOfBirth = new DateTime(year: 1965, month: 12, day: 22),
  FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia
};
bob.Children.Add(
  new Person()
  {
    Name = "Alfred Vazquez",
    DateOfBirth = new DateTime(year: 1980, month: 12, day: 10),
    FavoriteAncientWonder = WondersOfTheAncientWorld.ColossusOfRhodes
  });

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
