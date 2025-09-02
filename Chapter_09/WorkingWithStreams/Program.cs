using System.Xml;
using static System.Console;
using static System.Environment;
using static System.IO.Path;
using WorkingWithStreams.Shared;

static void WorkWithText()
{
  string textFile = Combine(CurrentDirectory, "streams.txt");
  StreamWriter text = File.CreateText(textFile);

  foreach (string item in Viper.Callsigns)
  {
    text.WriteLine(item);
  }
  text.Close();

  WriteLine("{0} contains {1:N0} bytes.", arg0: textFile, arg1: new FileInfo(textFile).Length);
  WriteLine(File.ReadAllText(textFile));
}

static void WorkWithXml()
{
  string xmlFile = Combine(CurrentDirectory, "streams.xml");
  FileStream? xmlFileStream = null;
  XmlWriter? xml = null;

  try
  {
    xmlFileStream = File.Create(xmlFile);
    xml = XmlWriter.Create(xmlFileStream, new XmlWriterSettings { Indent = true });

    xml.WriteStartDocument();
    xml.WriteStartElement("callsigns");
    foreach (string item in Viper.Callsigns)
    {
      xml.WriteElementString("callsign", item);
    }
    xml.WriteEndElement();

    xml.Close();
    xmlFileStream.Close();

    WriteLine("{0} contains {1:N0} bytes.", arg0: xmlFile, arg1: new FileInfo(xmlFile).Length);
    WriteLine(File.ReadAllText(xmlFile));
  }
  catch (Exception ex)
  {
    WriteLine($"{ex.GetType()} says {ex.Message}");
  }
  finally
  {
    if (xml != null)
    {
      xml.Dispose();
      WriteLine("The XML writer's unmanaged resources have been disposed.");
      if (xmlFileStream != null)
      {
        xmlFileStream.Dispose();
        WriteLine("The file stream's unmanaged resources have been disposed.");
      }
    }
  }
}

WorkWithText();
WorkWithXml();
