using Fejlesztesi_mintak.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fejlesztesi_mintak.Enities
{
    public class PresentFactory : IToyFactory
    {
        public Color ribbon_color { get; set; }
        public Color box_color { get; set; }
        public Toy CreateNew()
        { 
            return new Present(ribbon_color, box_color);
        }
    }
}
