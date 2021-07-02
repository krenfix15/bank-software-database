using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieClient
{
    public class Locatie
    {
        public int ID_LOCATIE { get; set; }

        public string Judet { get; set; }

        public string Abreviere { get; set; }

        public Locatie()
        {

        }

        public Locatie(string judet, string abreviere, int idLocatie = 0)
        {
            ID_LOCATIE = idLocatie;
            Judet = judet;
            Abreviere = abreviere;
        }

        public Locatie(DataRow linieDB)
        {
            ID_LOCATIE = Convert.ToInt32(linieDB["ID_LOCATIE"].ToString());
            Judet = linieDB["judet"].ToString();
            Abreviere = linieDB["abreviere"].ToString();
        }
    }
}
