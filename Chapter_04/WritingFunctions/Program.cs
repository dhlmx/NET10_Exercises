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

/// <summary>
/// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
/// </summary>
/// <param name="number">Number is a cardinal value e.g. 1, 2, 3, and so on.</param>
/// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on.</returns>
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

static int Factorial(int number)
{
  if (number < 1)
  {
    return 0;
  }
  else if (number == 1)
  {
    return 1;
  }
  else
  {
    checked
    {
      return number * Factorial(number - 1);
    }
  }
}

/// <summary>
/// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
/// </summary>
static int FibFunctional(int term) =>
  term switch
  {
    1 => 0,
    2 => 1,
    _ => FibFunctional(term - 1) + FibFunctional(term - 2)
  };

/// <summary>
/// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
/// </summary>
static int FibImperative(int term)
{
  if (term == 1)
  {
    return 0;
  }
  else if (term == 2)
  {
    return 1;
  }
  else
  {
    return FibImperative(term - 1) + FibImperative(term - 2);
  }
}

static void RunCardinalToOrdinal()
{
  for (int number = 1; number <= 40; number++)
  {
    Write($"{CardinalToOrdinal(number)} ");
  }
  WriteLine();
}

static void RunFactorial()
{
  for (int i = 1; i < 15; i++)
  {
    try
    {
      WriteLine($"{i}! = {Factorial(i):N0}");
    }
    catch (System.OverflowException)
    {
      WriteLine($"{i}! is too big for a 32-bit integer.");
    }
  }
}

static void RunFibFunctional()
{
  for (int i = 1; i <= 30; i++)
  {
    WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
      arg0: CardinalToOrdinal(i),
      arg1: FibFunctional(term: i));
  }
}

static void RunFibImperative()
{
  for (int i = 1; i <= 30; i++)
  {
    WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
      arg0: CardinalToOrdinal(i),
      arg1: FibImperative(term: i));
  }
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

RunFactorial();
WriteLine();

RunFibImperative();
WriteLine();

RunFibFunctional();
WriteLine();
