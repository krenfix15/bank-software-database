using System;
using System.Collections.Generic;
using System.Data;
using LibrarieClient;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareCarduri : IStocareCarduri
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public bool AddCard(Card c)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "INSERT INTO carduri_PM1 VALUES (seq_carduri_PM1.nextval, :Tip", CommandType.Text,
                new OracleParameter(":Tip", OracleDbType.NVarchar2, c.Tip, ParameterDirection.Input));
        }

        public Card GetCard(int id)
        {
            Card result = null;
            var dsCarduri = SqlDBHelper.ExecuteDataSet("select * from carduri_PM1 where ID_CARD = :ID_CARD", CommandType.Text,
                new OracleParameter(":ID_CARD", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsCarduri.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsCarduri.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Card(linieDB);
            }
            return result;
        }

        public List<Card> GetCarduri()
        {
            var result = new List<Card>();
            var dsCarduri = SqlDBHelper.ExecuteDataSet("select * from carduri_PM1", CommandType.Text);

            foreach (DataRow linieDB in dsCarduri.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Card(linieDB));
            }
            return result;
        }

        public bool UpdateCard(Card c)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE carduri_PM1 SET Tip = :Tip where ID_CARD = :ID_CARD", CommandType.Text,
                new OracleParameter(":Tip", OracleDbType.NVarchar2, c.Tip, ParameterDirection.Input),
                new OracleParameter(":ID_CARD", OracleDbType.Int32, c.ID_CARD, ParameterDirection.Input)
                );
        }
    }
}
