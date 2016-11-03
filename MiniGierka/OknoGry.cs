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

        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            gra.WczytajGrafike(grafika, new Rectangle(0, 0, panelGry.Width, panelGry.Height));
        }

        private void OknoGry_FormClosing(object sender, FormClosingEventArgs e)
        {
            gra.Zatrzymaj();
        }
    }
}
