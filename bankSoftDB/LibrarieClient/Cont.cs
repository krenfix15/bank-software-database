using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieClient
{
    public class Cont
    {
        public int ID_CONT { get; set; }

        public string CNP { get; set; }

        public int Perioada { get; set; }

        public int Sold { get; set; }
        public DateTime DataDepunere { get; set; }

        public decimal Dobanda { get; set; }

        public string TipCard { get; set; }

        //entitate aditionala
        public virtual Card Card { get; set; }

        public Cont()
        {

        }

        public Cont(int perioada, string cnp, int sold, DateTime dataDepunere, decimal dobanda, string tipCard, int idCont = 0)
        {
            ID_CONT = idCont;
            CNP = cnp;
            Perioada = perioada;
            Sold = sold;
            DataDepunere = dataDepunere;
            Dobanda = dobanda;
            TipCard = tipCard;
        }

        public Cont(DataRow linieDB)
        {
            ID_CONT = Convert.ToInt32(linieDB["ID_CONT"].ToString());
            CNP = linieDB["CNP"].ToString();
            Perioada = Convert.ToInt32(linieDB["Perioada"].ToString());
            Sold = Convert.ToInt32(linieDB["sold"].ToString());
            DataDepunere = Convert.ToDateTime(linieDB["DataDepunere"].ToString());
            Dobanda = Convert.ToDecimal(linieDB["Dobanda"].ToString());
            TipCard = linieDB["TipCard"].ToString();
        }
    }
}
