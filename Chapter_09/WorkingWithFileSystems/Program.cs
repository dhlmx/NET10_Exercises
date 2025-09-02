using static System.Console; 
using static System.IO.Directory; 
using static System.IO.Path;
using static System.Environment;

static void OutputFileSystemInfo()
{
  const string FORMAT = "{0,-33} {1}";
  WriteLine(FORMAT, arg0: "Path.PathSeparator", arg1: PathSeparator);
  WriteLine(FORMAT, arg0: "Path.DirectorySeparatorChar", arg1: DirectorySeparatorChar);
  WriteLine(FORMAT, arg0: "Directory.GetCurrentDirectory()", arg1: GetCurrentDirectory());
  WriteLine(FORMAT, arg0: "Environment.CurrentDirectory", arg1: CurrentDirectory);
  WriteLine(FORMAT, arg0: "Environment.SystemDirectory", arg1: SystemDirectory);
  WriteLine(FORMAT, arg0: "Path.GetTempPath()", arg1: GetTempPath());
  WriteLine("GetFolderPath(SpecialFolder");
  WriteLine(FORMAT, arg0: " .System)", arg1: GetFolderPath(SpecialFolder.System));
  WriteLine(FORMAT, arg0: " .ApplicationData)", arg1: GetFolderPath(SpecialFolder.ApplicationData));
  WriteLine(FORMAT, arg0: " .MyDocuments)", arg1: GetFolderPath(SpecialFolder.MyDocuments));
  WriteLine(FORMAT, arg0: " .Personal)", arg1: GetFolderPath(SpecialFolder.Personal));
}

static void WorkWithDrives()
{
  const string HEADER_FORMAT = "{0,-30} {1,-10} {2,-7} {3,18} {4,18}",
    DRIVE_FORMAT = "{0,-30} | {1,-10} | {2,-7} | {3,18:N0} | {4,18:N0}";
  WriteLine(HEADER_FORMAT, "NAME", "TYPE", "FORMAT", "SIZE (BYTES)", "FREE SPACE");

  foreach (DriveInfo drive in DriveInfo.GetDrives())
  {
    if (drive.IsReady)
    {
      WriteLine(DRIVE_FORMAT,
        drive.Name, drive.DriveType, drive.DriveFormat,
        drive.TotalSize, drive.AvailableFreeSpace);
    }
    else
    {
      WriteLine("{0,-30} | {1,-10}", drive.Name, drive.DriveType);
    }
  }
}

static void WorkWithDirectories()
{
  string newFolder = Combine(GetFolderPath(SpecialFolder.Personal), "Code", "Chapter09", "NewFolder");
  WriteLine($"Working with: {newFolder}");
  WriteLine($"Does it exist? {Directory.Exists(newFolder)}");

  WriteLine("Creating it...");
  CreateDirectory(newFolder);
  WriteLine($"Does it exist? {Directory.Exists(newFolder)}");
  Write("Confirm the directory exists, and then press ENTER: ");
  ReadLine();

  WriteLine("Deleting it...");
  Delete(newFolder, recursive: true);
  WriteLine($"Does it exist? {Directory.Exists(newFolder)}");
}

static void WorkWithFiles()
{
  string dir = Combine(GetFolderPath(SpecialFolder.Personal), "Code", "Chapter09", "OutputFiles");
  CreateDirectory(dir);

  string textFile = Combine(dir, "Dummy.txt");
  string backupFile = Combine(dir, "Dummy.bak");
  WriteLine($"Working with: {textFile}");

  WriteLine($"Does it exist? {File.Exists(textFile)}");

  StreamWriter textWriter = File.CreateText(textFile);
  textWriter.WriteLine("Hello, C#!");
  textWriter.Close(); // close file and release resources
  WriteLine($"Does it exist? {File.Exists(textFile)}");
  File.Copy(sourceFileName: textFile, destFileName: backupFile, overwrite: true);

  WriteLine(
    $"Does {backupFile} exist? {File.Exists(backupFile)}");
  Write("Confirm the files exist, and then press ENTER: ");
  ReadLine();

  File.Delete(textFile);
  WriteLine($"Does it exist? {File.Exists(textFile)}");

  WriteLine($"Reading contents of {backupFile}:");
  StreamReader textReader = File.OpenText(backupFile);
  WriteLine(textReader.ReadToEnd());
  textReader.Close();

  WriteLine($"Folder Name: {GetDirectoryName(textFile)}");
  WriteLine($"File Name: {GetFileName(textFile)}");
  WriteLine("File Name without Extension: {0}",
  GetFileNameWithoutExtension(textFile));
  WriteLine($"File Extension: {GetExtension(textFile)}");
  WriteLine($"Random File Name: {GetRandomFileName()}");
  WriteLine($"Temporary File Name: {GetTempFileName()}");

  FileInfo info = new(backupFile);
  WriteLine($"{backupFile}:");
  WriteLine($"Contains {info.Length} bytes");
  WriteLine($"Last accessed {info.LastAccessTime}");
  WriteLine($"Has readonly set to {info.IsReadOnly}");
  WriteLine("Is the backup file compressed? {0}", info.Attributes.HasFlag(FileAttributes.Compressed));
}

OutputFileSystemInfo();
WriteLine();
WorkWithDrives();
WriteLine();
WorkWithDirectories();
WriteLine();
WorkWithFiles();
WriteLine();
