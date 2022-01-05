using System;

namespace Kursach
{
    static class Graphics
    {
        public static void UpdateScreen(DrawPacket packet)
        {
            DrawBuffer buffer = new(Program.Height , Program.Width);

            packet.DrawToBuffer(buffer);
            string printable = buffer.PrintableString();

            Console.Clear();
            Console.WriteLine(printable);
        }
    }
}
