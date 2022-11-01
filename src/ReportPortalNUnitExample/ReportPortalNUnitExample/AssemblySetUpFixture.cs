using Microsoft.Extensions.Logging;
using NUnit.Framework;
using ReportPortal.Serilog;
using Serilog;
using Serilog.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportPortalNUnitExample
{
    
    [SetUpFixture]
    internal class AssemblySetUpFixture
    {
        internal static Microsoft.Extensions.Logging.ILogger logger;

        [OneTimeSetUp]
        public void OncePerAssembly()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel
                .Is(Serilog.Events.LogEventLevel.Verbose)
                .WriteTo
                .ReportPortal()
                .CreateLogger();

            logger = new SerilogLoggerFactory().CreateLogger(string.Empty);
        }
    }
}
