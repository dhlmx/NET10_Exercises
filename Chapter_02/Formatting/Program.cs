const string firstname = "Omar";
const string lastname = "Rudberg";
const string fullname = $"{firstname} {lastname}";

// { index [, alignment ] [ : formatString ] }
int numberOfApples = 12;
decimal pricePerApple = 0.35M;
string formatted = string.Format(
  format: "{0} apples costs {1:C}",
  arg0: numberOfApples,
  arg1: pricePerApple * numberOfApples);

string applesText = "Apples"; 
int applesCount = 1234;
string bananasText = "Bananas"; 
int bananasCount = 56789;

Console.WriteLine(
  format: "{0} apples costs {1:C}", 
  arg0: numberOfApples,
  arg1: pricePerApple * numberOfApples);

//WriteToFile(formatted);

Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");
Console.WriteLine(formatted);

Console.WriteLine(
  format: "{0,-10} {1,6}",
  arg0: "Name",
  arg1: "Count");

Console.WriteLine(
  format: "{0,-10} {1,6:N0}",
  arg0: applesText,
  arg1: applesCount);

Console.WriteLine(
  format: "{0,-10} {1,6:N0}",
  arg0: bananasText,
  arg1: bananasCount);
