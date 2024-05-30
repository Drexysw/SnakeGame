using SimpleSnake.Core;

namespace SimpleSnake
{
    using Utilities;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();
            Engine engine = new Engine();
            engine.Run();
        }
    }
}
