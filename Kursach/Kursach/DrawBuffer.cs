using System;
using System.Linq;

namespace Kursach
{
    class DrawBuffer
    {
        private readonly char[][] pixels;

        public int Height { get; }
        public int Width { get; }


        public void Draw(IDrawable drawable)
        {
            int permissibleWidth = Width - drawable.X;
            int permissibleHeight = Height - drawable.Y;

            int resultWidth = Math.Min(permissibleWidth , drawable.Width);
            int resultHeight = Math.Min(permissibleHeight , drawable.Height);

            int y = drawable.Y;
            int x = drawable.X;

            for ( int i = 0; i < resultHeight; i++ )
            {
                for ( int j = 0; j < resultWidth; j++ )
                {
                    pixels[y + i][x + j] = drawable[i , j];
                }
            }
        }

        public string PrintableString() => 
            pixels
            .Reverse()
            .Select(arr => new string(arr))
            .Aggregate((str1 , str2) => str1 + "\n" + str2);

        public DrawBuffer(int height , int width)
        {
            pixels = new char[height][];

            Height = height;
            Width = width;

            for ( int i = 0; i < height; i++ )
            {
                pixels[i] = new char[width];

                for ( int j = 0; j < width; j++ )
                {
                    pixels[i][j] = ' ';
                }
            }
        }
    }
}
