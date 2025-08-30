namespace LibC06V1.Shared;

public class Animal : IDisposable
{
  public Animal()
  {
    // allocate unmanaged resource
  }

  ~Animal() // Finalizer
  {
    Dispose(false);
  }

  bool disposed = false; // have resources been released?

  public void Dispose()
  {
    Dispose(true);

    // tell garbage collector it does not need to call the finalizer
    GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing)
  {
    if (disposed) return;
    // deallocate the *unmanaged* resource
    // ...

    if (disposing)
    {
      // deallocate any other *managed* resources
      // ...
    }
    
    disposed = true;
  }
}