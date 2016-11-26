using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniGierka
{
    class SilnikGraficzny
    {
        private Graphics grafika;
        private RectangleF granice;
        private Font font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);

        private Bitmap klatka;
        private Graphics grafikaKlatki;

        public RectangleF Granice { get { return granice; } }

        public SilnikGraficzny(Graphics grafika, Rectangle granice)
        {
            this.grafika = grafika;
            this.granice = granice;
            klatka = new Bitmap(granice.Width, granice.Height);
            grafikaKlatki = Graphics.FromImage(klatka);
        }

        public void Renderuj(List<ElementGry> elementy, int fps)
        {
            grafikaKlatki.FillRectangle(new SolidBrush(Color.Black), granice);

            #region Elementy gry
            
            foreach (var e in elementy)
            {
                grafikaKlatki.DrawImage(e.AktualnySprite, e.Granice);
            }

            #endregion

            string fpsstring = string.Format("{0} fps", fps);
            SizeF stringSize = grafika.MeasureString(fpsstring, font);
            grafikaKlatki.DrawString(fpsstring, font, new SolidBrush(Color.White),
                new PointF(granice.Right - stringSize.Width - 5, 5));

            grafika.DrawImage(klatka, 0, 0);
        }
    }
}
