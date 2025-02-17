using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaosFieldClash
{
    internal class Vector2D
    {
        public int X;
        public int Y;

        public Point ToPoint()
        {
            return new Point(X, Y);
        }
    }
}
