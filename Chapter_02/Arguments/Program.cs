#if NET6_0_ANDROID
// compile statements that only works on Android
#elif NET6_0_IOS
// compile statements that only works on iOS
#else
// compile statements that work everywhere else
#endif

using static System.Console;

WriteLine($"There are {args.Length} arguments.");

foreach (string arg in args)
{
  WriteLine(arg);
}

if (args.Length < 3)
{
  WriteLine("You must specify two colors and cursor size, e.g.");
  WriteLine("dotnet run red yellow 50");
  return; // stop running
}

ForegroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[0], ignoreCase: true);
BackgroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[1], ignoreCase: true);

try
{
  if (OperatingSystem.IsWindows())
  {
    WriteLine("execute code that only works on Windows");
  }
  else if (OperatingSystem.IsWindowsVersionAtLeast(major: 10))
  {
    WriteLine("execute code that only works on Windows 10 or later");
  }
  else if (OperatingSystem.IsIOSVersionAtLeast(major: 14, minor: 5))
  {
    WriteLine("execute code that only works on iOS 14.5 or later");
  }
  else if (OperatingSystem.IsBrowser())
  {
    WriteLine("execute code that only works in the browser with Blazor");
  }
  CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
  WriteLine("The current platform does not support changing the cursor size.");
}
catch (ArgumentOutOfRangeException)
{
  WriteLine("The cursor size must be between 1 and 100.");
}
catch (FormatException)
{
  WriteLine("The cursor size must be an integer.");
}
catch (OverflowException)
{
  WriteLine("The cursor size is too big or too small.");
}
finally
{
  WriteLine($"Foreground color: {ForegroundColor}");
  WriteLine($"Background color: {BackgroundColor}");
  WriteLine($"Cursor size: {CursorSize}");
}

