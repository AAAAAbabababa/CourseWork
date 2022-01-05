using System;
using System.Threading;

using Kursach.GameObjects;

namespace Kursach
{
    static class Program
    {
        public const int Height = 10;
        public const int Width = 90;

        public const float frameRate = 100;


        static void Main(string[] args)
        {
            Console.BufferWidth = 300;
            Console.BufferHeight = 200;

            Console.WindowWidth = 120;
            Console.WindowHeight = 25;

            Console.Title = "Динозавр";

            char[,] cactusPixels =
            {
                { '@' }
            };

            char[,] disosaurPixels =
            {
                { 'Y' }
            };

            Ground ground = new('#', 2, Width);
            Cactus cactus1 = new(20 , 2 , cactusPixels);
            Cactus cactus2 = new(40 , 2 , cactusPixels);
            Cactus cactus3 = new(70 , 2 , cactusPixels);
            Cactus cactus4 = new(80 , 2 , cactusPixels);
            Dinosaur dinosaur = new(disosaurPixels , 5 , 2, 2);
            CactiCounter cactiCounter = new(75 , 7);

            Cactus[] cacti = new Cactus[] { cactus1 , cactus2 , cactus3 , cactus4 };

            GameWorld world = new(ground , cacti , dinosaur , cactiCounter);
            

            GameLoop(world);
        }

        static void GameLoop(GameWorld world)
        {
            while ( world.IsPlaying )
            {
                world.Update();
                Controls.NewIteration();
                Graphics.UpdateScreen(world.GetDrawPacket());
                Thread.Sleep(100);
            }

            GameOver();
        }

        static void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Игра окончена");
        }
    }
}
