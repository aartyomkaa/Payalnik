using System;

namespace Loggers
{
    interface ILogger
    {
        void WriteError(string message);
    }
}
