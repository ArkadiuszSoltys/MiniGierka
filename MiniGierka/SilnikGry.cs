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

        public void WczytajGrafike(Graphics grafika, Rectangle granice)
        {
            this.grafika = new SilnikGraficzny(grafika, granice);
            this.grafika.Rozpocznij();
        }

        public void Zatrzymaj()
        {
            grafika.Zatrzymaj();
        }
    }
}
