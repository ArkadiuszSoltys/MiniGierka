using System;
using System.Collections.Generic;
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
        private Rectangle granice;
        private Font font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
        private Thread render;

        public SilnikGraficzny(Graphics grafika, Rectangle granice)
        {
            this.grafika = grafika;
            this.granice = granice;
        }

        public void Rozpocznij()
        {
            render = new Thread(new ThreadStart(renderuj));
            render.Start();
        }

        public void Zatrzymaj()
        {
            render.Abort();
        }

        private void renderuj()
        {
            int zrenderowanychKlatek = 0;
            long poczatekOdliczania = Environment.TickCount;
            int klatekNaSekunde = 0;

            Bitmap klatka = new Bitmap(granice.Width, granice.Height);
            Graphics grafikaKlatki = Graphics.FromImage(klatka);

            while(true)
            {
                grafikaKlatki.FillRectangle(new SolidBrush(Color.Black), granice);

                string text = string.Format("{0} fps", klatekNaSekunde);
                SizeF stringSize = grafika.MeasureString(text, font);
                grafikaKlatki.DrawString(text, font, new SolidBrush(Color.Green),
                    new PointF(granice.Right - stringSize.Width - 5, 5));

                grafika.DrawImage(klatka, 0, 0);
                zrenderowanychKlatek++;
                if (Environment.TickCount >= poczatekOdliczania + 1000)
                {
                    klatekNaSekunde = zrenderowanychKlatek;
                    zrenderowanychKlatek = 0;
                    poczatekOdliczania = Environment.TickCount;
                }
            }
        }
    }
}
