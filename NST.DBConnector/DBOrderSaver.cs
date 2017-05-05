using NST.Abstractions;
using System;
using NST.DomainModel;

namespace NST.DBConnector
{
    public class DBOrderSaver : IOrderSaver
    {
        public void Save(Order order)
        {
            //Some how persist to DB
        }
    }
}
