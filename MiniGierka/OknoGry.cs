using System;
using System.Drawing;
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
            gra.Przegrana += Przegrana;
        }

        private void Przegrana()
        {
            MessageBox.Show("Spowodowałeś kolizję! Na szczęście możesz zacząć od początku...", "Oooops!", MessageBoxButtons.OK);
        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gra.Zajety)
            {
                DialogResult rezulat = MessageBox.Show("Czy na pewno chcesz zacząć od początku?", "Nowa gra?", MessageBoxButtons.YesNo);

                if (rezulat != DialogResult.Yes)
                    return;
            }
            label_Klikajabyzaczac.Visible = false;

            gra.OdNowa(panelGry.CreateGraphics(), new Rectangle(0, 0, panelGry.Width, panelGry.Height));
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gra.Zajety)
            {
                DialogResult rezulat = MessageBox.Show("Czy na pewno chcesz opuścić grę?", "Wyjście", MessageBoxButtons.YesNo);
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
            if (!gra.Zajety)
            {
                nowaGraToolStripMenuItem_Click(null, null);
            }
        }

        private void OknoGry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!gra.Zajety)
                return;
            gra.WcisnietyKlawisz(e);
        }
    }
}
