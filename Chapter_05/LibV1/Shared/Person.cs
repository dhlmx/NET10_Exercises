using System;
using System.Collections.Generic;
using static System.Console;

namespace LibV1.Shared;

public class Person
{
  public string Name { get; set; } = string.Empty;
  public DateTime DateOfBirth { get; set; }
  public WondersOfTheAncientWorld FavoriteAncientWonder { get; set; }
  public WondersOfTheAncientWorld BucketList { get; set; }
  public List<Person> Children { get; set; } = [];
}
