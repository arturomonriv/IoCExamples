using NST.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NST.Abstractions
{
    public interface IOrderService
    {
        void AddOrder(Order order);
    }
}
