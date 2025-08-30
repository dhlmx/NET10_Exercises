using System.Text.RegularExpressions;

namespace LibC06V1.Shared;

public static partial class StringExtensions
{
  [GeneratedRegex(@"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+")]
  private static partial Regex MyRegex();

  public static bool IsValidEmail(this string input)
  {
    return MyRegex().IsMatch(input);
  }
}
