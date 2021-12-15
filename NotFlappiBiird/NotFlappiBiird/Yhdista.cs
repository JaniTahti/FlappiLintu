using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace NotFlappiBiird
{
    /*Tulee virhe kun yrittää pyörittää tämän koodin kanssa. Virhe nimeltä CS1705, jos haluaa katsoa asiaa. Omissa projekteissa toimii tämä ihan hyvin ja ne ovat 5.0
     * target framework. Tämä projekti on target framework 4.7.2, en ole varma vaikuttaako tämä siihen virheeseen.
     */

    /*class Yhdista
    {
        public string yhteysLause()
        {

            return "datasource=localhost;port=3306;username=root; password=1234;database=käyttäjät";

        }
        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306; username=root; password=1234; database=tiedot");

        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }

        public void avaaSuljeYhteys()
        {
            if (yhteys.State == MySqlConnection.Closed)
            {
                yhteys.Open();
            }
            else if (yhteys.State == MySqlConnection.Open)
            {
                yhteys.Close();
            }
        }
    }*/
}
