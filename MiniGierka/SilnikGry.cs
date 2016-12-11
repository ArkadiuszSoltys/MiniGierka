using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGierka
{
    class SilnikGry
    {
        private SilnikGraficzny grafika;
        private List<ElementGry> elementy;
        private Random random = new Random(Environment.TickCount);
        private Thread watek;
        private Gracz gracz;

        public bool Zajety { get { return watek != null && watek.IsAlive; } }
        public ZdarzeniePrzegrana Przegrana = null;

        public void Wczytaj(Graphics grafika, Rectangle granice)
        {
            elementy = new List<ElementGry>();
            this.grafika = new SilnikGraficzny(grafika, granice);
        }

        public void Rozpocznij()
        {
            watek = new Thread(new ThreadStart(gra));
            watek.Start();
        }

        public void WcisnietyKlawisz(KeyPressEventArgs e)
        {
            RectangleF granice = new RectangleF(0, 75, grafika.Granice.Width, 210);
            switch(e.KeyChar)
            {
                case 'W':
                case 'w':
                    gracz.SkrecWLewo();
                    gracz.SprawdzPozycje(granice);
                    break;
                case 'S':
                case 's':
                    gracz.SkrecWPrawo();
                    gracz.SprawdzPozycje(granice);
                    break;
            }
        }

        private void gra()
        {
            int zrenderowanychKlatek = 0;
            int klatekNaSekunde = 0;
            long poczatekOdliczania = Environment.TickCount;

            long czasOstatniegoSpawnu = poczatekOdliczania;

            double delta = 0;
            long deltaCzas = poczatekOdliczania;

            Tlo tlo = new Tlo();
            elementy.Add(tlo);
            tlo.Respawn(grafika.Granice);
            
            gracz = new Gracz();
            elementy.Add(gracz);
            gracz.Respawn(grafika.Granice.Left + 25, grafika.Granice.Top + 145);
            
            Pojazd nowyPojazd;
            while (true)
            {
                delta = (Environment.TickCount - deltaCzas) / 1000.0f;
                deltaCzas = Environment.TickCount;

                if (Environment.TickCount >= czasOstatniegoSpawnu + (Stale.PRZESZKODA_OPOZNIENIE * 1000))
                {
                    if (random.Next(0, 100) <= Stale.PRZESZKODA_SZANSA)
                    {
                        nowyPojazd = new Pojazd();
                        elementy.Add(nowyPojazd);
                        nowyPojazd.Respawn(grafika.Granice.Right - 1, grafika.Granice.Top + 75 + (70 * random.Next(0, 3)));
                    }
                    czasOstatniegoSpawnu = Environment.TickCount;
                }

                foreach(var e in elementy)
                {
                    e.Aktualizuj(delta);
                    if (!e.Granice.IntersectsWith(grafika.Granice))
                        e.Usun();

                    if (e as Pojazd != null && gracz.Granice.IntersectsWith(e.Granice))
                    {
                        Przegrana();
                        return;
                    }
                }
                elementy.RemoveAll(i => i.DoUsuniecia == true);

                grafika.Renderuj(elementy, klatekNaSekunde);

                zrenderowanychKlatek++;
                if (Environment.TickCount >= poczatekOdliczania + 1000)
                {
                    klatekNaSekunde = zrenderowanychKlatek;
                    zrenderowanychKlatek = 0;
                    poczatekOdliczania = Environment.TickCount;
                }
            }
            
        }

        public void OdNowa(Graphics grafika, Rectangle granice)
        {
            Zatrzymaj();
            Wczytaj(grafika, granice);
            Rozpocznij();
        }

        public void Zatrzymaj()
        {
            if (watek == null)
                return;
            watek.Abort();
        }

        internal delegate void ZdarzeniePrzegrana();
    }
}
