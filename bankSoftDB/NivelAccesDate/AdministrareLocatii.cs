using System;
using System.Collections.Generic;
using System.Data;
using LibrarieClient;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareLocatii : IStocareLocatii
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public bool AddLocatie(Locatie l)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "INSERT INTO locatii_PM1 VALUES (seq_locatii_PM1.nextval, :Judet, :Abreviere", CommandType.Text,
                new OracleParameter(":Judet", OracleDbType.NVarchar2, l.Judet, ParameterDirection.Input),
                new OracleParameter(":Abreviere", OracleDbType.NVarchar2, l.Abreviere, ParameterDirection.Input));
        }

        public Locatie GetLocatie(int id)
        {
            Locatie result = null;
            var dsLocatii = SqlDBHelper.ExecuteDataSet("select * from locatii_PM1 where ID_LOCATIE = :ID_LOCATIE", CommandType.Text,
                new OracleParameter(":ID_LOCATIE", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsLocatii.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsLocatii.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Locatie(linieDB);
            }
            return result;
        }

        public List<Locatie> GetLocatii()
        {
            var result = new List<Locatie>();
            var dsLocatii = SqlDBHelper.ExecuteDataSet("select * from locatii_PM1", CommandType.Text);

            foreach (DataRow linieDB in dsLocatii.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Locatie(linieDB));
            }
            return result;
        }

        public bool UpdateLocatie(Locatie l)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE locatii_PM1 SET Judet = :Judet, Abreviere = :Abreviere where ID_LOCATIE = :ID_LOCATIE", CommandType.Text,
                new OracleParameter(":Judet", OracleDbType.NVarchar2, l.Judet, ParameterDirection.Input),
                new OracleParameter(":Abreviere", OracleDbType.NVarchar2, l.Abreviere, ParameterDirection.Input),
                new OracleParameter(":ID_LOCATIE", OracleDbType.Int32, l.ID_LOCATIE, ParameterDirection.Input)
                );
        }
    }
}
