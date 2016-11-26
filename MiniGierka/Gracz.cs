using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGierka
{
    class Gracz : ElementGry
    {
        public Gracz()
        {
            aktualnySprite = Properties.Resources.gracz;
        }

        public void Respawn(float x, float y)
        {
            size.Width = 80;
            size.Height = 55;
            location.X = x;
            location.Y = y;
        }
    }
}
