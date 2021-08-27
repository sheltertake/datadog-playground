using Serilog;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Serilog.Debugging.SelfLog.Enable(Console.Error);
            
            var logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.File(new Serilog.Formatting.Json.JsonFormatter(renderMessage: true), "logs/console-app.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            using (Serilog.Context.LogContext.PushProperty("order-number", 1024))
            {
                logger.Information("Message before a trace.");

                using (var scope = Datadog.Trace.Tracer.Instance.StartActive("SerilogExample - Main()"))
                {
                    logger.Information("Message during a trace.");
                }

                logger.Information("Message after a trace.");
            }

        }
    }
}
