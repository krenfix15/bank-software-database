using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieClient
{
    public class Card
    {
        public int ID_CARD { get; set; }

        public string Tip { get; set; }

        public Card()
        {

        }

        public Card(string tip, int idCard = 0)
        {
            ID_CARD = idCard;
            Tip = tip;
        }

        public Card(DataRow linieDB)
        {
            ID_CARD = Convert.ToInt32(linieDB["ID_CARD"].ToString());
            Tip = linieDB["tip"].ToString();
        }
    }
}
