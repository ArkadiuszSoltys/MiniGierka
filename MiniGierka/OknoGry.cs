using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGierka
{
    public partial class OknoGry : Form
    {
        private Form oknoAutorzy;
        private SilnikGry gra = new SilnikGry();

        public OknoGry()
        {
            InitializeComponent();
        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gra.Zajety)
            {
                DialogResult rezulat = MessageBox.Show("Od nowa?", "Odnowa?", MessageBoxButtons.YesNo);

                if (rezulat != DialogResult.Yes)
                    return;
            }
            
            gra.OdNowa(panelGry.CreateGraphics(), new Rectangle(0, 0, panelGry.Width, panelGry.Height));
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gra.Zajety)
            {
                DialogResult rezulat = MessageBox.Show("Koniec?", "Koniec?", MessageBoxButtons.YesNo);
                if (rezulat != DialogResult.Yes)
                    return;
            }
            this.Close();
        }

        private void oAutorachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oknoAutorzy == null)
            {
                oknoAutorzy = new OknoAutorzy();
            }
               
            oknoAutorzy.ShowDialog(this);
        }

        private void panelGry_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafika = panelGry.CreateGraphics();
            gra.Wczytaj(grafika, new Rectangle(0, 0, panelGry.Width, panelGry.Height));
        }

        private void OknoGry_FormClosing(object sender, FormClosingEventArgs e)
        {
            gra.Zatrzymaj();
        }

        private void panelGry_Click(object sender, EventArgs e)
        {
            gra.Kliknij(MousePosition.X, MousePosition.Y);
        }
    }
}
