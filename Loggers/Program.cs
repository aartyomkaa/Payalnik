using System;

namespace Loggers
{
    class Program
    {
        public static void Main(string[] args)
        {
            var FileWriter = new Pathfinder(new FileLogWriter());
            var ConsoleWriter = new Pathfinder(new ConsoleLogWriter());
            var FridayFileWriter = new Pathfinder(new FridayLogWriter(new FileLogWriter()));
            var FridayConsoleWriter = new Pathfinder(new FridayLogWriter(new ConsoleLogWriter()));
            var ConsoleAndFridayFileWriter = new Pathfinder(new ChainLogWriter(new ConsoleLogWriter(), new FridayLogWriter(new FileLogWriter())));
        }
    }
}
