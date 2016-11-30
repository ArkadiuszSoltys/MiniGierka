using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGierka
{
    class Tlo : ElementGry
    {
        private int krokAnimacji = 0;
        protected List<Bitmap> sprites = new List<Bitmap>();
        private int szybkoscAnimacji = 100;
        private long ostatniKrok;

        public Tlo()
        {
            sprites.Add(Properties.Resources.tlo_1);
            sprites.Add(Properties.Resources.tlo_2);
            aktualnySprite = sprites[0];
            ostatniKrok = Environment.TickCount;
        }

        public override void Aktualizuj(double deltaTime)
        {
            if (Environment.TickCount < ostatniKrok + szybkoscAnimacji)
                return;

            aktualnySprite = sprites[krokAnimacji++];
            ostatniKrok = Environment.TickCount;
            if (krokAnimacji >= sprites.Count)
                krokAnimacji = 0;
        }

        public void Respawn(RectangleF granice)
        {
            size = granice.Size;
            location = granice.Location;
        }
    }
}
