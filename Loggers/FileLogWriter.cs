using System;

namespace Loggers
{
    class FileLogWriter : ILogger
    {
        public void WriteError(string message)
        {
            File.WriteAllText("log.txt", message);
        }
    }
}
