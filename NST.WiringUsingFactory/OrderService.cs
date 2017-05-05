using NST.Abstractions;
using NST.DomainModel;
using System;

namespace NST.WiringUsingFactory
{
    public class OrderService
    {
        private IOrderSaver orderSaver;

        public OrderService(ConnectorType connectorType)
        {
            this.orderSaver = OrderServiceFactory.Get(connectorType);
        }

        public void AcceptOrder(Order order)
        {
            orderSaver.Save(order);
        }
    }
}
