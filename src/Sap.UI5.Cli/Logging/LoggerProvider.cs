using Microsoft.Extensions.Logging;

namespace Sap.UI5.Cli
{
    public class LoggerProvider : ILoggerProvider
    {
        private readonly LoggerOptions options;

        public LoggerProvider(LoggerOptions options)
        {
            this.options = options;
        }

        public void Dispose()
        {
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new ConsoleLogger(this.options);
        }
    }
}
