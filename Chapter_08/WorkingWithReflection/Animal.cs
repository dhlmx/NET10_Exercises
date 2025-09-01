using static System.Console;

namespace WorkingWithReflection;

public class Animal
{

  [Coder("John", "22 August 2021")]
  [Coder("Jane", "13 September 2021")]
  public void Speak() => WriteLine("Grrrrr!");
}
