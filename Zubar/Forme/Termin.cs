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
    public partial class Termin : Form
    {
        DataTable tabela;
        SqlDataAdapter doktor = null, pacijent = null, dijagnoza = null;
        SqlConnection veza = null;
        private List<string> vremena = new List<string>();
        public Termin()
        {
            popuniVremena();
            InitializeComponent();
            for (int i = 0; i < vremena.Count; i++)
            {
                cbPocetak.Items.Add(vremena[i]);
                cbZavrsetak.Items.Add(vremena[i]);
            }
            Ucitaj();
            cbPacijent.SelectedIndex = -1;
            cbDoktor.SelectedIndex = -1;
            cbDijagnoza.SelectedIndex = -1;
            
        }

        private void popuniVremena()
        {
            for(int i = 9; i < 17; i++)
            {
                vremena.Add(i.ToString("D2") + ":00");
                vremena.Add(i.ToString("D2") + ":30");
            }
        }
        private void tbCena_TextChanged(object sender, EventArgs e)
        {
            string cena = tbCena.Text;
            int rezultat = 0;
            if (!int.TryParse(cena, out rezultat))
                tbCena.Text = "";

        }

        private void cbPacijent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPacijent.SelectedIndex == -1)
                return;

            int doktor_id = UcitajIzabranogLekara((int)cbPacijent.SelectedValue);
            if(doktor_id > -1)
            {
                cbDoktor.SelectedValue = doktor_id;
            }
        }

        private int UcitajIzabranogLekara(int pacijent_id)
        {
            SqlCommand naredba = new SqlCommand("SELECT doktor_id  FROM Karton WHERE pacijent_id = " + pacijent_id.ToString(), veza);
            int doktor_id = -1;
            try
            {
                veza.Open();
                doktor_id = (int)naredba.ExecuteScalar();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }

            return doktor_id;
        }

        private void btnIZMENI_Click(object sender, EventArgs e)
        {
            if (cbPacijent.SelectedIndex == -1 || cbDoktor.SelectedIndex == -1 || cbDijagnoza.SelectedIndex == -1
                || cbPocetak.SelectedIndex == -1 || cbZavrsetak.SelectedIndex == -1 ||
                dtDatum.Value == null)
                return;

            string pacijent_id = cbPacijent.SelectedValue.ToString();
            string doktor_id = cbDoktor.SelectedValue.ToString();
            string dijagnoza_id = cbDijagnoza.SelectedValue.ToString();
            string datum = dtDatum.Value.ToString();
            string vreme_pocetka = cbPocetak.Text + ":00";
            string vreme_zavrsetka = cbZavrsetak.Text + ":00";
            string cena = tbCena.Text;
            
            StringBuilder Naredba = new StringBuilder("INSERT INTO  Termin (pacijent_id,doktor_id,dijagnoza_id ,datum,vreme_pocetka,vreme_zavrsetka,cena) VALUES (");
            Naredba.Append( pacijent_id + ", ");
            Naredba.Append(doktor_id + ", ");
            Naredba.Append(dijagnoza_id + ", '");
            Naredba.Append(datum + "', '");
            Naredba.Append(vreme_pocetka + "', '");
            Naredba.Append(vreme_zavrsetka + "', ");
            Naredba.Append(cena + ")");
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();

                Close();
            }
            catch (Exception GRESKA)
            {
                MessageBox.Show(GRESKA.Message);
            }

        }

        private void cbPocetak_SelectedValueChanged(object sender, EventArgs e)
        {
            cbZavrsetak.Items.Clear();
            int pocetak = cbPocetak.SelectedIndex;
            for (int i = pocetak+1; i < vremena.Count; i++)
            {
                cbZavrsetak.Items.Add(vremena[i]);
            }
        }

        private void Ucitaj()
        {
            veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Termin", veza);


            pacijent = new SqlDataAdapter("SELECT id, ime + ' ' + prezime AS ime_i_prezime FROM Pacijent", veza);
            DataTable pacijenti = new DataTable();
            pacijent.Fill(pacijenti);
            cbPacijent.ValueMember = "id";
            cbPacijent.DisplayMember = "ime_i_prezime";
            cbPacijent.DataSource = pacijenti;

            doktor = new SqlDataAdapter("SELECT id, ime + ' ' + prezime AS ime_i_prezime FROM Doktor", veza);
            DataTable doktori = new DataTable();
            doktor.Fill(doktori);
            cbDoktor.ValueMember = "id";
            cbDoktor.DisplayMember = "ime_i_prezime";
            cbDoktor.DataSource = doktori;

            dijagnoza = new SqlDataAdapter("SELECT id, opis FROM Dijagnoza", veza);
            DataTable dijagnoze = new DataTable();
            dijagnoza.Fill(dijagnoze);
            cbDijagnoza.ValueMember = "id";
            cbDijagnoza.DisplayMember = "opis";
            cbDijagnoza.DataSource = dijagnoze;

            tabela = new DataTable();
            adapter.Fill(tabela);
        }
    }
}
