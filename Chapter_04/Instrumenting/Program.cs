using Microsoft.Extensions.Configuration;
using System.Diagnostics;

Trace.Listeners.Add(
  new TextWriterTraceListener(
    File.CreateText(
      Path.Combine(
        @"G:\dev\NET\NET10_Exercises\Chapter_04\Instrumenting",
        "log.txt"
      )
    )
  ));

Trace.AutoFlush = true;

Debug.WriteLine("Debug says, I'm watching v2.0");
Trace.WriteLine("Trace says, I'm watching v2.0");

ConfigurationBuilder builder = new();

builder.SetBasePath(Directory.GetCurrentDirectory())
  .AddJsonFile(
    "appsettings.json",
    optional: true,
    reloadOnChange: true
  );

IConfigurationRoot configuration = builder.Build();

TraceSwitch ts = new(
  displayName: "PacktSwitch",
  description: "This switch is set via a JSON config"
);

configuration.GetSection("PacktSwitch").Bind(ts);

Trace.WriteLineIf(ts.TraceError, "Trace error"); 
Trace.WriteLineIf(ts.TraceWarning, "Trace warning"); 
Trace.WriteLineIf(ts.TraceInfo, "Trace information");
Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");

