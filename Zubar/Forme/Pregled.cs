using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zubar.Forme
{
    public partial class Pregled : Form
    {
        
        SqlConnection veza = null;
        string imeKljuca;
        public Pregled(string kljuc)
        {
            imeKljuca = kljuc;
            InitializeComponent();
            lbIme.Text = kljuc + ":";
            Ucitaj();
        }

        private void Ucitaj()
        {
            veza = Konekcija.Connect();
            SqlDataAdapter kljuc  = new SqlDataAdapter("SELECT id, ime + ' ' + prezime AS ime_i_prezime FROM " + imeKljuca, veza);

            DataTable kljucevi = new DataTable();
            kljuc.Fill(kljucevi);
            cbKljuc.ValueMember = "id";
            cbKljuc.DisplayMember = "ime_i_prezime";
            cbKljuc.DataSource = kljucevi;
            cbKljuc.SelectedIndex = -1;
        }

        private void cbKljuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKljuc.SelectedIndex == -1)
            {
                dgPregled.DataSource = null;
                return;
            }

            int id = (int)cbKljuc.SelectedValue;
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT Termin.id, Termin.datum, Termin.vreme_pocetka,Termin.vreme_zavrsetka,Termin.cena,Pacijent.ime + ' ' + Pacijent.prezime AS pacijent, Doktor.ime + ' ' + Doktor.prezime AS doktor, Dijagnoza.opis as dijagnoza FROM Termin  JOIN Pacijent ON Termin.pacijent_id=pacijent.id JOIN Doktor ON Termin.doktor_id=Doktor.id JOIN Dijagnoza ON Termin.dijagnoza_id = Dijagnoza.id WHERE " + imeKljuca + "_id=" + id.ToString() , Konekcija.Connect());
            DataTable tabela = new DataTable();
            Adapter.Fill(tabela);
            dgPregled.DataSource = tabela;
        }
    }
}
