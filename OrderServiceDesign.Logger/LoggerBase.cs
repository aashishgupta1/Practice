using Serilog;
namespace OrderServiceDesign.Logger
{
    public class LoggerBase : ILoggerBase
    {
        ILogger _logger;
        public LoggerBase(ILogger logger)
        {
            _logger = logger;
        }
        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Information(string message)
        {
            _logger.Information(message);
        }

        public void Warning(string message)
        {
            _logger.Warning(message);
        }
    }
}
