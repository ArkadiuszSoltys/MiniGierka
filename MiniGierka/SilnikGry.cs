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
    class SilnikGry
    {
        private SilnikGraficzny grafika;
        private List<ElementGry> elementy;
        private Random random = new Random();
        private Thread watek;

        public bool Zajety { get { return watek != null && watek.IsAlive; } }

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

        private void gra()
        {
            int zrenderowanychKlatek = 0;
            int klatekNaSekunde = 0;
            long poczatekOdliczania = Environment.TickCount;

            long czasOstatniegoSpawnu = poczatekOdliczania;

            double delta = 0;
            long deltaCzas = poczatekOdliczania;

            while (true)
            {
                delta = (Environment.TickCount - deltaCzas) / 1000.0f;
                deltaCzas = Environment.TickCount;
                if (Environment.TickCount >= czasOstatniegoSpawnu + (Stale.OPOZNIENIE_RESPAWNU * 1000))
                {
                    if (random.Next(0, 100) <= Stale.SZANSA_RESPAWNU)
                    {
                        Pojazd nowyPojazd = Pojazd.Wygeneruj((KierunekJazdy)random.Next((int)KierunekJazdy.Pierwszy, (int)KierunekJazdy.Ostatni));
                        elementy.Add(nowyPojazd);
                        nowyPojazd.Jedz();
                        czasOstatniegoSpawnu = Environment.TickCount;
                    }
                }

                foreach(var e in elementy)
                {
                    e.Aktualizuj(delta);
                    if (e.Granice.Right >= grafika.Granice.Right)
                    {
                        e.Usun();
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

        public void Kliknij(int x, int y)
        {
            foreach(var element in elementy)
            {
                if (!element.ReagujeNaKlikniecie)
                    continue;

                if (element.Granice.Contains(x, y))
                    element.Kliknieto();
            }
        }
    }
}
