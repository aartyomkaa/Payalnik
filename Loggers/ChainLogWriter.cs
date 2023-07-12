using System;

namespace Loggers
{
    class ChainLogWriter : ILogger
    {
        private ILogger[] _loggers;

        public ChainLogWriter(params ILogger[] loggers)
        {
            _loggers = loggers;
        }

        public void WriteError(string message)
        {
            foreach (var logger in _loggers)
            {
                logger.WriteError(message);
            }
        }
    }
}
