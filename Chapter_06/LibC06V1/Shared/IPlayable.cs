using static System.Console;

namespace LibC06V1.Shared;

public interface IPlayable
{
  void Play();
  void Pause();

  void Stop()
  {
    WriteLine("Default implementation of Stop.");
  }
}
