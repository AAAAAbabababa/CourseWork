using System.Collections.Generic;

namespace Kursach
{
    class DrawPacket
    {
        private readonly IEnumerable<IDrawable> drawables;

        public void DrawToBuffer(DrawBuffer buffer)
        {
            foreach ( var drawable in drawables )
            {
                buffer.Draw(drawable);
            }
        }

        public DrawPacket(IEnumerable<IDrawable> drawables)
        {
            this.drawables = drawables;
        }
    }
}
