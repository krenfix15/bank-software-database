using LibrarieClient;
using System;
using System.Collections;
using System.Collections.Generic;


namespace NivelAccesDate
{
    public interface IStocareClienti: IStocareFactory
    {
        List<Client> GetClienti();
        Client GetClient(int id);
        bool AddClient(Client c);

        bool UpdateClient (Client c);

        bool DeleteClient(string cnp);
    }
}
