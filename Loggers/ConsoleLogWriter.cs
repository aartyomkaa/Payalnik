using System;

namespace Loggers
{
    class ConsoleLogWriter : ILogger
    {
        public void WriteError(string message)
        {
            Console.WriteLine(message);
        }
    }
}