using LibV1;
using static System.Console;

/*
static bool TryParse(string? input, out Person value)
{
  if (someFailure)
  {
    value = default(Person);
    return false;
  }
  // successfully parsed the string into a Person
  value = new Person() { ... };
  return true;
}
*/

WriteLine("In Main");
Alpha();

static void Alpha()
{
  WriteLine("In Alpha");
  Beta();
}

static void Beta()
{
  WriteLine("In Beta");

  try
  {
    Calculator.Gamma();
  }
  catch (Exception ex)
  {
    WriteLine($"Caught exception in Beta: {ex.Message}");
    throw; //new Exception("Exception in Beta", ex);
  }
}
