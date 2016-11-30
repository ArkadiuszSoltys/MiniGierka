using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGierka
{
    class ElementGry
    {
        protected PointF location = new PointF(0, 0);
        protected SizeF size = new SizeF(32, 32);
        protected Bitmap aktualnySprite;
        protected bool doUsuniecia = false;
        
        public RectangleF Granice { get { return new RectangleF(location, size); } }
        public Bitmap AktualnySprite { get { return aktualnySprite; } }
        public bool DoUsuniecia { get { return doUsuniecia; } }

        public void Usun()
        {
            doUsuniecia = true;
        }

        virtual public void Aktualizuj(double deltaTime) { }
    }
}
