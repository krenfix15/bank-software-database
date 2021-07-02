using NivelAccesDate;
using System;
using System.Configuration;
using LibrarieClient;

namespace bankSoftForm
{
    /// <summary>
    /// Factory Design Pattern
    /// </summary>
    public class StocareFactory
    {
        public IStocareFactory GetTipStocare(Type tipEntitate)
        {
            var formatSalvare = ConfigurationManager.AppSettings["FormatSalvare"];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "BazaDateOracle":

                        if (tipEntitate == typeof(Client))
                        {
                            return new AdministrareClienti();
                        }
                        if (tipEntitate == typeof(Cont))
                        {
                            return new AdministrareConturi();
                        }
                        if (tipEntitate == typeof(Card))
                        {
                            return new AdministrareCarduri();
                        }
                        if (tipEntitate == typeof(Locatie))
                        {
                            return new AdministrareLocatii();
                        }
                        break;

                    case "BIN":
                        //instantiere clase care realizeaza salvarea in fisier binar
                        break;
                }
            }
            return null;
        }
    }
}
