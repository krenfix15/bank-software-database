using LibrarieClient;
using System;
using System.Collections;
using System.Collections.Generic;


namespace NivelAccesDate
{
    public interface IStocareConturi: IStocareFactory
    {
        List<Cont> GetConturi();
        Cont GetCont(string cnp);
        bool AddCont(Cont c);

        bool UpdateCont(Cont c);

        bool DeleteCont(string cnp);
    }
}
