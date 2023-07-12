using System;

namespace Loggers
{
    class FridayLogWriter : ILogger
    {
        private ILogger _logger;

        public FridayLogWriter(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteError(string message)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                _logger.WriteError(message);
            }
        }
    }
}
