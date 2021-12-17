using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Eramake;


namespace NotFlappiBiird
{
    public partial class kirjautumisForm : Form
    {
        public kirjautumisForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Vaihdetaan salasanakenttä näkyväksi tai piiloon
        {
            if (salasanaTB.UseSystemPasswordChar == true)
            {
                salasanaTB.UseSystemPasswordChar = false;
            }
            else
            {
                salasanaTB.UseSystemPasswordChar = true;
            }
        }

        private void kirjauduBT_Click(object sender, EventArgs e) //Luodaan uusi yhteys ja haetaan käyttäjät ja tiedot tietokannasta
        {
            Yhdista yht = new Yhdista();
            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            String qr = "SELECT `Ktunnus`, `Ssana` FROM `tiedot` WHERE `Ktunnus` =@ktunnus AND `Ssana` =@ssana";
            MySqlCommand komento = new MySqlCommand();

            komento.CommandText = qr;
            komento.Connection = yht.otaYhteys();

            komento.Parameters.Add("@ktunnus", MySqlDbType.VarChar).Value = ktunnusTB.Text;
            komento.Parameters.Add("@ssana", MySqlDbType.VarChar).Value = salasanaTB.Text;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            if (taulu.Rows.Count > 0) //Jos kaikki onnistuu, menee eteenpäin ja avaa pelin
            {
                this.Hide();
                Form1 peli = new Form1();
                peli.Show();
            }
            else
            {
                if (ktunnusTB.Text.Trim().Equals("")) //Jos käyttäjänimen kenttä on tyhjä, virheviesti
                {
                    MessageBox.Show("Syötä käyttäjänimi", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (salasanaTB.Text.Trim().Equals("")) //Jos salasanan kenttä on tyhjä, virheviesti
                {
                    MessageBox.Show("Syötä salasana", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //Jos ei löydy syötettyä käyttäjää tai salasanaa, virheviesti
                {
                    MessageBox.Show("Tätä käyttäjää tai salasanaa ei ole olemassa", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }


        }

        private void kirjautumisForm_FormClosing(object sender, FormClosingEventArgs e) //Kun suljetaan kirjautumisikkuna, sulkee koko ohjelman
        {
            Environment.Exit(0);
        }
    }
}
