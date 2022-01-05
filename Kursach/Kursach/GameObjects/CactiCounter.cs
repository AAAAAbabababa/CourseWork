namespace Kursach.GameObjects
{
    class CactiCounter : GameObject
    {
        int points = 0;
        const int width = 15;
        const int height = 3;
        const int row = 1;

        private void PrintPoints(int points)
        {
            for ( int i = 1; i < width - 1; i++ )
            {
                pixels[row , i] = ' ';
            }


            string text = points.ToString();
            int textWidth = text.Length;

            int margin = ((width - 2 - textWidth) / 2) + 1;

            for ( int i = 0; i < textWidth; i++ )
            {
                pixels[row , i + margin] = text[i];
            }
        }

        public override void Update(GameWorld world)
        {
            bool dinosaurIsContactCactus = world.ObjectsCacti
                .Exists(cactus => cactus.X == world.ObjectDinosaur.X && cactus.Y == world.ObjectDinosaur.Y);

            bool dinosaurIsAboveCactus = world.ObjectsCacti
                .Exists(cactus => cactus.X == world.ObjectDinosaur.X);

            if ( dinosaurIsContactCactus )
            {
                world.ObjectDinosaur.Kill();
            }
            else if ( dinosaurIsAboveCactus )
            {
                points++;
                PrintPoints(points);
            }
        }

        public CactiCounter(int x, int y)
        {
            X = x;
            Y = y;

            pixels = new char[height , width];

            for ( int i = 0; i < height; i++ )
            {
                for ( int j = 0; j < width; j++ )
                {
                    pixels[i , j] = '#';
                }
            }

            PrintPoints(points);
        }
    }
}
