using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Zubar.Forme
{
    public partial class Karton : Form
    {
        int broj_sloga = 0;
        DataTable tabela;
        SqlDataAdapter doktor = null;
        SqlConnection veza = null;
        public Karton()
        {
            InitializeComponent();
        }

        private void Karton_Load(object sender, EventArgs e)
        {
            Ucitaj();
            Txt_Load();
        }

        private string UcitajPacijenta(int pacijent_id)
        {
            SqlCommand naredba = new SqlCommand("SELECT ime + ' ' + prezime AS ime_i_prezime FROM Pacijent WHERE id = " + pacijent_id.ToString() , veza);
            string ime_i_prezime = "";
            try
            {
                veza.Open();
                ime_i_prezime = (string)naredba.ExecuteScalar();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }

            return ime_i_prezime;
        }
        private void Ucitaj()
        {
            veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Karton", veza);
            doktor = new SqlDataAdapter("SELECT id, ime + ' ' + prezime AS ime_i_prezime FROM Doktor", veza);

            DataTable doktori = new DataTable();
            doktor.Fill(doktori);
            cbDoktor.DataSource = doktori;
            cbDoktor.ValueMember = "id";
            cbDoktor.DisplayMember = "ime_i_prezime";
            
            tabela = new DataTable();
            adapter.Fill(tabela);
        }

        private void Txt_Load()
        {
            if (tabela.Rows.Count == 0)
            {
                tbID.Text = "";
                tbPacijent.Text = "";
                cbDoktor.SelectedIndex = -1;
                tbStanje.Text = "";
            }
            else
            {
                tbID.Text = tabela.Rows[broj_sloga]["id"].ToString();
                tbPacijent.Text = UcitajPacijenta((int)tabela.Rows[broj_sloga]["pacijent_id"]);
                if (tabela.Rows[broj_sloga]["doktor_id"].ToString() == "")
                    cbDoktor.SelectedIndex = -1;
                else
                    cbDoktor.SelectedValue = tabela.Rows[broj_sloga]["doktor_id"];
                tbStanje.Text = tabela.Rows[broj_sloga]["stanje"].ToString();
            }

            if (broj_sloga == tabela.Rows.Count - 1)
            {
                btnSLEDECI.Enabled = false;
                btnPOSLEDNJI.Enabled = false;
            }
            else
            {
                btnSLEDECI.Enabled = true;
                btnPOSLEDNJI.Enabled = true;
            }

            if (broj_sloga == 0)
            {
                btnPRETHODNI.Enabled = false;
                btnPRVI.Enabled = false;
            }
            else
            {
                btnPRETHODNI.Enabled = true;
                btnPRVI.Enabled = true;
            }
        }

        private void btnIZMENI_Click(object sender, EventArgs e)
        {
            string doktor_id = "";
            if(cbDoktor.SelectedIndex != -1)
                doktor_id = cbDoktor.SelectedValue.ToString();

            StringBuilder Naredba = new StringBuilder("UPDATE Karton SET ");
            if(doktor_id !="")
                Naredba.Append("doktor_id = '" + doktor_id + "', ");
            Naredba.Append("stanje = '" + tbStanje.Text + "'");

            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception GRESKA)
            {
                MessageBox.Show(GRESKA.Message);
            }

        }

        private void btnPRVI_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            Txt_Load();
        }

        private void btnPRETHODNI_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            Txt_Load();
        }

        private void btnSLEDECI_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            Txt_Load();
        }

        private void btnPOSLEDNJI_Click(object sender, EventArgs e)
        {
            broj_sloga = tabela.Rows.Count - 1;
            Txt_Load();
        }
    }
}
