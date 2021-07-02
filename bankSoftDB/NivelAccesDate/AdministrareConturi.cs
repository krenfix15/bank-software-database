using System;
using System.Collections.Generic;
using System.Data;
using LibrarieClient;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareConturi : IStocareConturi
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public bool AddCont(Cont c)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "INSERT INTO conturi_PM1 VALUES (seq_conturi_PM1.nextval, :CNP, :Perioada, :Sold, :DataDepunere, :Dobanda, :TipCard)", CommandType.Text,
                new OracleParameter(":CNP", OracleDbType.NVarchar2, c.CNP, ParameterDirection.Input),
                new OracleParameter(":Perioada", OracleDbType.Int32, c.Perioada, ParameterDirection.Input),
                new OracleParameter(":Sold", OracleDbType.Int32, c.Sold, ParameterDirection.Input),
                new OracleParameter(":DataDepunere", OracleDbType.Date, c.DataDepunere, ParameterDirection.Input),
                new OracleParameter(":Dobanda", OracleDbType.Decimal, c.Dobanda, ParameterDirection.Input),
                new OracleParameter(":TipCard", OracleDbType.NVarchar2, c.TipCard, ParameterDirection.Input)
                );
        }

        public Cont GetCont(string cnp)
        {
            Cont result = null;
            var dsConturi = SqlDBHelper.ExecuteDataSet("select * from conturi_PM1 WHERE CNP = :CNP", CommandType.Text,
                new OracleParameter(":CNP", OracleDbType.NVarchar2, cnp, ParameterDirection.Input));

            if (dsConturi.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsConturi.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Cont(linieDB);
            }
            return result;
        }

        public List<Cont> GetConturi()
        {
            var result = new List<Cont>();
            var dsConturi = SqlDBHelper.ExecuteDataSet("select * from conturi_PM1", CommandType.Text);

            foreach (DataRow linieDB in dsConturi.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Cont(linieDB));
            }
            return result;
        }

        public bool UpdateCont(Cont c)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE conturi_PM1 SET CNP = :CNP, Perioada = :Perioada, Sold = :Sold, DataDepunere = :DataDepunere, Dobanda = :Dobanda, TipCard = :TipCard where ID_CONT = :ID_CONT", CommandType.Text,
                new OracleParameter(":CNP", OracleDbType.NVarchar2, c.CNP, ParameterDirection.Input),
                new OracleParameter(":Perioada", OracleDbType.Int32, c.Perioada, ParameterDirection.Input),
                new OracleParameter(":Sold", OracleDbType.Int32, c.Sold, ParameterDirection.Input),
                new OracleParameter(":DataDepunere", OracleDbType.Date, c.DataDepunere, ParameterDirection.Input),
                new OracleParameter(":Dobanda", OracleDbType.Decimal, c.Dobanda, ParameterDirection.Input),
                new OracleParameter(":TipCard", OracleDbType.NVarchar2, c.TipCard, ParameterDirection.Input),
                new OracleParameter(":ID_CONT", OracleDbType.Int32, c.ID_CONT, ParameterDirection.Input)
                );
        }

        public bool DeleteCont(string cnp)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "DELETE FROM conturi_PM1 WHERE CNP = :CNP", CommandType.Text,
                new OracleParameter(":CNP", OracleDbType.NVarchar2, cnp, ParameterDirection.Input)
                );
        }
    }
}
