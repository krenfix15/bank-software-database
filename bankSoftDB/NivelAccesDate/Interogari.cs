using System;
using System.Collections.Generic;
using System.Data;
using LibrarieClient;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public static class Interogari
    {
        public static bool interogare1(int sold)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "SELECT * FROM clienti_PM1 clienti, conturi_PM1 conturi WHERE clienti.CNP = conturi.CNP AND conturi.Sold > :SOLD", CommandType.Text,
                new OracleParameter(":SOLD", OracleDbType.Int32, sold, ParameterDirection.Input)
                );
        }

        public static bool interogare4(int idLocatie)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "SELECT clienti.ID_CONT FROM clienti_PM1 clienti, locatii_PM1 locatii WHERE clienti.Judet = locatii.Judet AND locatii.ID_LOCATIE = :ID_LOCATIE", CommandType.Text,
                new OracleParameter(":ID_LOCATIE", OracleDbType.Int32, idLocatie, ParameterDirection.Input)
                );
        }

        public static bool interogare8()
        {
            return SqlDBHelper.ExecuteNonQuery(
                "SELECT AVG(conturi.Sold) FROM clienti_PM1 clienti, conturi_PM1 conturi WHERE clienti.CNP = conturi.CNP AND conturi.DataDepunere > TO_DATE('30-06-2021','DD-MM-YYYY')", CommandType.Text
                );
        }

        public static bool interogare9()
        {
            return SqlDBHelper.ExecuteNonQuery(
                "SELECT COUNT(clienti.ID_CLIENT) FROM clienti_PM1 clienti, conturi_PM1 conturi, locatii_PM1 locatii WHERE clienti.CNP = conturi.CNP AND clienti.Judet = locatii.Judet AND(SYSDATE - TO_DATE(conturi.DataDepunere, 'DD-MM-YYYY')) > (SELECT SYSDATE - TO_DATE(conturi.DataDepunere, 'DD-MM-YYYY') FROM clienti_PM1 clienti, conturi_PM1 conturi, locatii_PM1 locatii WHERE clienti.CNP = conturi.CNP AND clienti.Judet = locatii.Judet AND locatii.Judet = 'Iasi')", CommandType.Text
                );
        }

        public static bool interogare10()
        {
            return SqlDBHelper.ExecuteNonQuery(
                "SELECT * FROM clienti_PM1 clienti, conturi_PM1 conturi, locatii_PM1 locatii WHERE clienti.CNP = conturi.CNP AND clienti.Judet = locatii.Judet AND conturi.TipCard = 'MasterCard' ORDER BY locatii.Judet, conturi.Sold DESC", CommandType.Text
                );
        }
    }
}
