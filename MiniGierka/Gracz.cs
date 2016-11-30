using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGierka
{
    class Gracz : ElementGry
    {
        private bool skrecWLewo = false;
        private bool skrecWPrawo = false;

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

        public override void Aktualizuj(double deltaTime)
        {
            if(skrecWLewo)
            {
                location.Y -= (float)(30 * deltaTime);
            }

            skrecWLewo = false;
            skrecWPrawo = false;
        }

        public void SkrecWPrawo()
        {
            skrecWPrawo = true;
        }

        public void SkrecWLewo()
        {
            skrecWLewo = true;
        }
    }
}
