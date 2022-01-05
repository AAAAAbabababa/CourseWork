namespace Kursach
{
    interface IDrawable
    {
        int X { get; }
        int Y { get; }

        int Width { get; }
        int Height { get; }

        char this[int row, int col] { get; }
    }
}
