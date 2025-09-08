using System.Xml.Serialization; // XmlSerializer
using System.Text.Json; // JsonSerializer
using NewJson = System.Text.Json.JsonSerializer;
using WorkingWithSerialization; // Person
using static System.Console; 
using static System.Environment;
using static System.IO.Path;

List<Person> people = new()
{
  new(30000M)
  {
    FirstName = "Alice",
    LastName = "Smith",
    DateOfBirth = new(1974, 3, 14)
  },
  new(40000M)
  {
    FirstName = "Bob",
    LastName = "Jones",
    DateOfBirth = new(1969, 11, 23)
  },
  new(20000M)
  {
    FirstName = "Charlie",
    LastName = "Cox",
    DateOfBirth = new(1984, 5, 4),
    Children = new()
    {
      new(0M)
      {
        FirstName = "Sally",
        LastName = "Cox",
        DateOfBirth = new(2000, 7, 12)
      }
    }
  }
};

XmlSerializer xs = new(people.GetType());
string path = Combine(CurrentDirectory, "people.xml");

using (FileStream stream = File.Create(path))
{
  xs.Serialize(stream, people);
}

WriteLine("Written {0:N0} bytes of XML to {1}",
  arg0: new FileInfo(path).Length,
  arg1: path);

WriteLine();
WriteLine(File.ReadAllText(path));

using (FileStream xmlLoad = File.Open(path, FileMode.Open))
{
  List<Person>? loadedPeople = xs.Deserialize(xmlLoad) as List<Person>;

  if (loadedPeople is not null)
  {
    foreach (Person p in loadedPeople)
    {
      WriteLine("{0} has {1} children.", p.LastName, p.Children?.Count ?? 0);
    }
  }
}

string jsonPath = Combine(CurrentDirectory, "people.json");

using (StreamWriter jsonStream = File.CreateText(jsonPath))
{
  Newtonsoft.Json.JsonSerializer jss = new();
  jss.Serialize(jsonStream, people);
}
WriteLine();

WriteLine("Written {0:N0} bytes of JSON to: {1}",
  arg0: new FileInfo(jsonPath).Length,
  arg1: jsonPath);
WriteLine(File.ReadAllText(jsonPath));

using (FileStream jsonLoad = File.Open(jsonPath, FileMode.Open))
{
  List<Person>? loadedPeople =
    await NewJson.DeserializeAsync(utf8Json: jsonLoad, returnType: typeof(List<Person>)) as List<Person>;

  if (loadedPeople is not null)
  {
    foreach (Person p in loadedPeople)
    {
      WriteLine("{0} has {1} children.", p.LastName, p.Children?.Count ?? 0);
    }
  }
}
