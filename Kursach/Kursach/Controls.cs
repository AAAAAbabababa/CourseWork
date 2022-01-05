using System;
using System.Threading.Tasks;

namespace Kursach
{
    static class Controls
    {
        static event Action<ConsoleKey> ConsoleKeyPressed;
        public static bool IsSpacePressed { get; private set; }

        static void EventLoop()
        {
            while ( true )
            {
                var keyInfo = Console.ReadKey();
                ConsoleKeyPressed(keyInfo.Key);
            }
        }

        public static void NewIteration()
        {
            IsSpacePressed = false;
        }

        static Controls()
        {
            ConsoleKeyPressed += OnConsoleKeyPressed;
            Task.Run(EventLoop);
        }

        static void OnConsoleKeyPressed(ConsoleKey key)
        {
            if ( key == ConsoleKey.Spacebar )
            {
                IsSpacePressed = true;
            }
        }
    }
}
