namespace Kursach.GameObjects
{
    class Cactus : GameObject
    {
        public override void Update(GameWorld _)
        {
            if ( X == 0)
            {
                X = Program.Width - 1;
            }
            else
            {
                X--;
            }
        }

        public Cactus(int x, int y, char[,] pixels)
        {
            X = x;
            Y = y;

            this.pixels = pixels;
        }
    }
}
