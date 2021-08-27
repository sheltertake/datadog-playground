using Serilog;
using System;

namespace DatadogConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Serilog.Debugging.SelfLog.Enable(Console.Error);

            var logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.File(
                    new Serilog.Formatting.Json.JsonFormatter(renderMessage: true), 
                    "logs/datadog-console-app.txt", 
                    rollingInterval: RollingInterval.Day)
                .CreateLogger();

            logger.Information("Starting app...");

        }
    }
}
