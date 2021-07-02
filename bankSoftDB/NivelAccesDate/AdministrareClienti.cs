using System;
using System.Collections.Generic;
using System.Data;
using LibrarieClient;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareClienti: IStocareClienti
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public bool AddClient(Client c)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "INSERT INTO clienti_PM1 VALUES (seq_clienti_PM1.nextval, :Nume, :Prenume, :CNP, :DataNastere, :Email, :Telefon, :Judet)", CommandType.Text,
                new OracleParameter(":Nume", OracleDbType.NVarchar2, c.Nume, ParameterDirection.Input),
                new OracleParameter(":Prenume", OracleDbType.NVarchar2, c.Prenume, ParameterDirection.Input),
                new OracleParameter(":CNP", OracleDbType.NVarchar2, c.CNP, ParameterDirection.Input),
                new OracleParameter(":DataNastere", OracleDbType.Date, c.DataNastere, ParameterDirection.Input),
                new OracleParameter(":Email", OracleDbType.NVarchar2, c.Email, ParameterDirection.Input),
                new OracleParameter(":Telefon", OracleDbType.NVarchar2, c.Telefon, ParameterDirection.Input),
                new OracleParameter(":Judet", OracleDbType.NVarchar2, c.Judet, ParameterDirection.Input)
                );
        }

        public Client GetClient(int id)
        {
            Client result = null;
            var dsClienti = SqlDBHelper.ExecuteDataSet("select * from clienti_PM1 where ID_CLIENT = :ID_CLIENT", CommandType.Text,
                new OracleParameter(":ID_CLIENT", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsClienti.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsClienti.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Client(linieDB);
            }
            return result;
        }

        public List<Client> GetClienti()
        {
            var result = new List<Client>();
            var dsClienti = SqlDBHelper.ExecuteDataSet("select * from clienti_PM1", CommandType.Text);

            foreach (DataRow linieDB in dsClienti.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Client(linieDB));
            }
            return result;
        }

        public bool UpdateClient(Client c)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE clienti_PM1 SET Nume = :Nume, Prenume = :Prenume, CNP = :CNP, DataNastere = :DataNastere, Email = :Email, Telefon = :Telefon, Judet = :Judet where ID_CLIENT = :ID_CLIENT", CommandType.Text,
                new OracleParameter(":Nume", OracleDbType.NVarchar2, c.Nume, ParameterDirection.Input),
                new OracleParameter(":Prenume", OracleDbType.NVarchar2, c.Prenume, ParameterDirection.Input),
                new OracleParameter(":CNP", OracleDbType.NVarchar2, c.CNP, ParameterDirection.Input),
                new OracleParameter(":DataNastere", OracleDbType.Date, c.DataNastere, ParameterDirection.Input),
                new OracleParameter(":Email", OracleDbType.NVarchar2, c.Email, ParameterDirection.Input),
                new OracleParameter(":Telefon", OracleDbType.NVarchar2, c.Telefon, ParameterDirection.Input),
                new OracleParameter(":Judet", OracleDbType.NVarchar2, c.Judet, ParameterDirection.Input),
                new OracleParameter(":ID_CLIENT", OracleDbType.Int32, c.ID_CLIENT, ParameterDirection.Input)
                );
        }

        public bool DeleteClient(string cnp)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "DELETE FROM clienti_PM1 WHERE CNP = :CNP", CommandType.Text,
                new OracleParameter(":CNP", OracleDbType.NVarchar2, cnp, ParameterDirection.Input)
                );
        }
    }
}
