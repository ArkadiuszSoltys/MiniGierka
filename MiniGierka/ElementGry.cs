using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGierka
{
    class ElementGry
    {
        private Rectangle granice = new Rectangle(0,0,0,0);
        private List<Bitmap> sprites = new List<Bitmap>();

        public static ZdarzenieClick Kliknieto = null;
    }

    internal delegate void ZdarzenieClick();
}
