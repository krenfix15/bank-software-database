using LibrarieClient;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareLocatii: IStocareFactory
    {
        List<Locatie> GetLocatii();
        Locatie GetLocatie(int id);
        bool AddLocatie(Locatie l);

        bool UpdateLocatie(Locatie l);
    }
}
