using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace ReportPortalNUnitExample
{
    public class Tests
    {
        internal ILogger log = AssemblySetUpFixture.logger;

        [Test]
        public void Test_With_Different_Microsoft_ILogger_Log_Levels()
        {
            log.LogDebug("Debug level log here");
            log.LogInformation("Info log level here");
            log.LogError("Error log level here");
        }
    }
}