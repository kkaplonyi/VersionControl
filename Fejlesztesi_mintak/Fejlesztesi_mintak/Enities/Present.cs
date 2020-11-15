using Fejlesztesi_mintak.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejlesztesi_mintak.Enities
{
    public class Present : Toy
    {
        public SolidBrush ribbon_color { get; private set; }

        public SolidBrush box_color { get; private set; }
        public Present(Color ribbon, Color box)
        {
            ribbon_color = new SolidBrush(ribbon);
            box_color = new SolidBrush(box);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(box_color, 0, 0, Width, Height);
            g.FillRectangle(ribbon_color, 20, 0, Width / 5, Height);
            g.FillRectangle(ribbon_color, 0, 20, Width, Height/5);
        }
    }
}
