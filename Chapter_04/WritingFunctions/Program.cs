using static System.Console;

static decimal CalculateTax(decimal amount, string regionCode)
{
  decimal rate = regionCode.ToUpper() switch
  {
    // Switzerland
    "CH" => 0.08M,
    // Denmark
    "DK" or "NO" => 0.25M,
    // United Kingdom
    "GB" or "FR" => 0.2M,
    // Hungary
    "HU" => 0.27M,
    // Oregon
    "OR" or "AK" or "MT" => 0.0M,
    // North Dakota
    "ND" or "WI" or "ME" or "VA" => 0.05M,
    // California
    "CA" => 0.0825M,
    // México
    "MX" => 0.15M,
    // most US states
    _ => 0.06M,
  };

  return amount * rate;
}

static string CardinalToOrdinal(int number)
{
  return number switch
  {
    11 or 12 or 13 => $"{number}th",
    _ => (number % 10) switch
    {
      1 => $"{number}st",
      2 => $"{number}nd",
      3 => $"{number}rd",
      _ => $"{number}th"
    }
  };
}

static void RunCardinalToOrdinal()
{
  for (int number = 1; number <= 40; number++)
  {
    Write($"{CardinalToOrdinal(number)} ");
  }
  WriteLine();
}

static void TimesTable(byte number)
{
  WriteLine($"This is the {number} times table:");
  for (int row = 1; row <= 12; row++)
  {
    WriteLine($"{row} x {number} = {row * number}");
  }
  WriteLine();
}

TimesTable(6);
WriteLine();

decimal amount = 149.0M;
string regionCode = "MX";
decimal taxToPay = CalculateTax(amount, regionCode); 
WriteLine($"For an amount of {amount}, you must pay {taxToPay:C} in tax in {regionCode}.");
WriteLine();

RunCardinalToOrdinal();
WriteLine();
