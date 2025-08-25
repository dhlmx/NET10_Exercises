namespace LibV1.Shared;

public partial class Person
{
  public string Origin
  {
    get
    {
      return $"{Name} was born on {HomePlanet}";
    }
  }

  public string Greeting => "${Name} says Hello!";
  public int Age => System.DateTime.Today.Year - DateOfBirth.Year;

  public string FavoriteIceCream { get; set; }

  private string favoritePrimaryColor;
  public string FavoritePrimaryColor
  {
    get
    {
      return favoritePrimaryColor;
    }

    set
    {
      favoritePrimaryColor = value.ToLower() switch
      {
        "red" or "green" or "blue" => value,
        _ => throw new System.ArgumentException(
                  $"{value} is not a primary color. " +
                  "Choose from: red, green, blue."),
      };
    }
  }
  
  public Person this[int index]
  {
    get
    {
      return Children[index]; // pass on to the List<T> indexer
    }
    set
    {
      Children[index] = value;
    }
  }

}
