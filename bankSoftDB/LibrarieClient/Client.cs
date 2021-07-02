using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieClient
{
    public class Client
    {
        public int ID_CLIENT { get; set; }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string CNP { get; set; }

        public string Telefon { get; set; }

        public string Email { get; set; }

        public DateTime DataNastere { get; set; }

        public string Judet { get; set; }

        //entitate aditionala
        public virtual Cont Cont { get; set; }

        //entitate aditionala
        public virtual Locatie Locatie { get; set; }

        public Client()
        {

        }

        public Client(string nume, string prenume, string cnp, string telefon, string email, DateTime dataNastere, string judet, int idClient = 0)
        {
            ID_CLIENT = idClient;
            Nume = nume;
            Prenume = prenume;
            CNP = cnp;
            Telefon = telefon;
            Email = email;
            DataNastere = dataNastere;
            Judet = judet;
        }

        public Client(DataRow linieDB)
        {
            ID_CLIENT = Convert.ToInt32(linieDB["ID_CLIENT"].ToString());
            Nume = linieDB["Nume"].ToString();
            Prenume = linieDB["Prenume"].ToString();
            CNP = linieDB["CNP"].ToString();
            Telefon = linieDB["Telefon"].ToString();
            Email = linieDB["Email"].ToString();
            DataNastere = Convert.ToDateTime(linieDB["DataNastere"].ToString());
            Judet = linieDB["Judet"].ToString();
        }
    }
}
