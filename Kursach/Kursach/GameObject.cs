namespace Kursach
{
    abstract class GameObject : IDrawable
    {
        protected char[,] pixels;
        public char this[int row , int col] => pixels[row, col];

        public int X { get; protected set; }
        public int Y { get; protected set; }
        public int Height => pixels.GetLength(0);
        public int Width => pixels.GetLength(1);

        public abstract void Update(GameWorld world);
    }
}
