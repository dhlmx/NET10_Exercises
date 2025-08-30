using static System.Console;

namespace LibC06V1.Shared;

public class DvdPlayer : IPlayable
{
  public void Play() => WriteLine("Playing DVD.");
  public void Pause() => WriteLine("Pausing DVD.");
}
