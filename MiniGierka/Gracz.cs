using System;
using System.Collections.Generic;
using System.Drawing;
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

        public void SkrecWPrawo()
        {
            location.Y += Stale.GRACZ_PREDKOSC_RUCHU;
        }

        public void SkrecWLewo()
        {
            location.Y -= Stale.GRACZ_PREDKOSC_RUCHU;
        }

        public void SprawdzPozycje(RectangleF granice)
        {
            if (Granice.Top < granice.Top)
                location.Y = granice.Top;
            if (Granice.Bottom > granice.Bottom)
                location.Y = granice.Bottom - size.Height;
        }
    }
}
