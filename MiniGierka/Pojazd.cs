using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGierka
{
    internal enum KolorPojazdow
    {
        Bialy,

        Pierwszy = Bialy,
        Ostatni = Bialy
    }

    internal enum KierunekJazdy
    {
        Poludnie,
        Wschod,

        Pierwszy = Poludnie,
        Ostatni = Wschod
    }

    class Pojazd : ElementGry
    {
        private int predkoscMaks;
        private int predkosc = 0;
        private KolorPojazdow kolor;
        private KierunekJazdy kierunek;
        private static Random random = new Random();

        private Pojazd() { }

        public bool Jedzie { get { return predkosc > 0; } }

        public Pojazd(KolorPojazdow kolor, int predkoscMaks, KierunekJazdy kierunek)
        {
            this.kolor = kolor;
            this.predkoscMaks = predkoscMaks;
            this.kierunek = kierunek;
        }

        public static Pojazd Wygeneruj(KierunekJazdy kierunek)
        {
            Pojazd pojazd = new Pojazd();
            pojazd.predkoscMaks = random.Next(30, 100);
            pojazd.kierunek = kierunek;
            pojazd.kolor = KolorPojazdow.Bialy;
            return pojazd;
        }

        public void Respawn()
        {
            size.Width = 64;
            size.Height = 64;

            switch (kierunek)
            {
                case KierunekJazdy.Poludnie:
                    location.X = 20;
                    location.Y = 20;
                    break;
                case KierunekJazdy.Wschod:
                    location.X = 20;
                    location.Y = 40;
                    break;
            }
        }

        public override void Aktualizuj(double deltaTime)
        {
            switch(kierunek)
            {
                case KierunekJazdy.Poludnie:
                    location.X += (float)(predkosc * deltaTime);
                    break;
            }
        }

        public void Jedz()
        {
            predkosc = predkoscMaks;
        }

        public void Zatrzymaj()
        {
            predkosc = 0;
        }
    }
}
