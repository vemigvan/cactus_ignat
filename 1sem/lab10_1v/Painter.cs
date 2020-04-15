using System.Collections.Generic;

namespace lab9_1v
{
    class Painter
    {
        public static void DrawShape(IDraw shape)
        {
            shape.Draw();
        }

    }
}
