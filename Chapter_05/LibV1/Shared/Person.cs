using System;
using System.Collections.Generic;
using static System.Console;
using static System.Tuple;
using static System.ValueTuple;

namespace LibV1.Shared;

public partial class Person
{
  public const string Species = "Homo Sapiens";
  public readonly string HomePlanet = "Earth";
  public readonly DateTime Instantiated;

  public string Name { get; set; } = string.Empty;
  public DateTime DateOfBirth { get; set; }
  public WondersOfTheAncientWorld FavoriteAncientWonder { get; set; }
  public WondersOfTheAncientWorld BucketList { get; set; }
  public List<Person> Children { get; set; } = [];

  public Person()
  {
    Name = "Unknown";
    Instantiated = DateTime.Now;
  }

  public Person(string initialName, string homePlanet)
  {
    Name = initialName;
    HomePlanet = homePlanet;
    Instantiated = DateTime.Now;
  }

  public void WriteToConsole()
  {
    WriteLine($"{Name} was born on a {DateOfBirth:dddd}");
  }

  public string GetOrigin()
  {
    return $"{Name} was born on {HomePlanet}";
  }

  public (string, int) GetFruit()
  {
    return ("Apples", 5);
  }

  public (string Name, int Number) GetNamedFruit()
  {
    return (Name: "Apples", Number: 5);
  }

  // Deconstructors
  public void Deconstruct(out string name, out DateTime dob)
  {
    name = Name;
    dob = DateOfBirth;
  }

  public void Deconstruct(out string name, out DateTime dob, out WondersOfTheAncientWorld fav)
  {
    name = Name;
    dob = DateOfBirth;
    fav = FavoriteAncientWonder;
  }

  public string SayHello()
  {
    return $"{Name} says 'Hello!'";
  }

  public string SayHello(string name)
  {
    return $"{Name} says 'Hello {name}!'";
  }

  public string OptionalParameters(
    string command = "Run!",
    double number = 0.0,
    bool active = true)
  {
    return string.Format(
      format: "command is {0}, number is {1}, active is {2}",
      arg0: command,
      arg1: number,
      arg2: active);
  }

  public void PassingParameters(int x, ref int y, out int z)
  {
    // out parameters cannot have a default
    // AND must be initialized inside the method
    z = 99;
    // increment each parameter
    x++; 
    y++; 
    z++;
  }
}
