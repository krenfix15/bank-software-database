using LibrarieClient;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareCarduri: IStocareFactory
    {
        List<Card> GetCarduri();
        Card GetCard(int id);
        bool AddCard(Card c);

        bool UpdateCard(Card c);
    }
}
