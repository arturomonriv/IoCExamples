
using NST.DomainModel;
using System;


namespace NST.Abstractions
{
    public interface IOrderSaver
    {
        void Save(Order order);
    }
}
