namespace Kursach.GameObjects
{
    class Ground : GameObject
    {
        public override void Update(GameWorld _)
        {
            
        }

        public Ground(char symbol, int height, int width)
        {
            pixels = new char[height , width];

            for ( int i = 0; i < height; i++ )
            {
                for ( int j = 0; j < width; j++ )
                {
                    pixels[i , j] = symbol;
                }
            }
        }
    }
}
