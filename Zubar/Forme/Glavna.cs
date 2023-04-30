using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zubar.Forme;

namespace Zubar
{
    public partial class Glavna : Form
    {
        Form trenutnaForma = null;
        public Glavna()
        {
            InitializeComponent();
        }
        private void zameniFormu(Form novaForma)
        {
            if (trenutnaForma != null)
            {
                trenutnaForma.Close();
                Controls.Remove(trenutnaForma);
            }

            novaForma.TopLevel = false;
            novaForma.FormBorderStyle = FormBorderStyle.None;
            novaForma.Top = 50;
            novaForma.Left = 50;
            Controls.Add(novaForma);
            trenutnaForma = novaForma;
            novaForma.Show();
        }
        private void dijagnozeTSMI_Click(object sender, EventArgs e)
        {
            zameniFormu(new Sifarnik("Dijagnoza"));
        }

        private void pacijentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zameniFormu(new Sifarnik("Pacijent"));
        }

        private void doktoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zameniFormu(new Sifarnik("Doktor"));
        }

        private void kartoniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zameniFormu(new Karton());
        }

        private void izadjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trenutnaForma != null)
            {
                trenutnaForma.Close();
                Controls.Remove(trenutnaForma);
                trenutnaForma = null;
            }
        }

        private void terminiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zameniFormu(new Termin());
        }

        private void terminiPoPacijentimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zameniFormu(new Pregled("Pacijent"));
        }

        private void terminiPoDoktorimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zameniFormu(new Pregled("Doktor"));
        }
    }
}
