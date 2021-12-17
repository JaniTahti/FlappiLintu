﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace NotFlappiBiird
{
    class Yhdista
    {
        public string yhteysLause()
        {
            return "datasource=localhost; port=3306; username=root; password=1234; database=käyttäjät";
        }

        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306; username=root; password=1234; database=tiedot");

        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }

        public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }

    }
}
