using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGierka
{
    class SilnikGry
    {
        private SilnikGraficzny grafika;
        private List<ElementGry> elementy;

        public SilnikGraficzny Grafika { get { return grafika; } }

        public void Wczytaj(Graphics grafika, Rectangle granice)
        {
            elementy = new List<ElementGry>();
            this.grafika = new SilnikGraficzny(grafika, granice);
        }

        public void Rozpocznij()
        {
            grafika.Rozpocznij();
        }

        public void OdNowa(Graphics grafika, Rectangle granice)
        {
            Zatrzymaj();
            Wczytaj(grafika, granice);
            Rozpocznij();
        }

        public void Zatrzymaj()
        {
            grafika.Zatrzymaj();
        }

        public void Kliknij(int x, int y)
        {

        }
    }
}
