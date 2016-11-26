using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGierka
{
    class Pojazd : ElementGry
    {
        static List<Bitmap> Sprites = new List<Bitmap>()
        {
            Properties.Resources.auto_1,
            Properties.Resources.auto_2,
            Properties.Resources.auto_3,
            Properties.Resources.auto_4
        };
        static Random random = new Random();

        public Pojazd()
        {
            aktualnySprite = Sprites[random.Next(0, Sprites.Count - 1)];
        }

        public override void Aktualizuj(double deltaTime)
        {
            location.X -= (float)(Stale.PRZESZKODA_PREDKOSC * deltaTime);
        }

        public void Respawn(float x, float y)
        {
            size.Width = 162;
            size.Height = 56;
            location.X = x;
            location.Y = y;
        }
    }
}
