using NST.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NST.Abstractions
{
    public interface IOrderService
    {
        void Configure(ConnectorType connectorType);

        void AddOrder(Order order);
    }
}
