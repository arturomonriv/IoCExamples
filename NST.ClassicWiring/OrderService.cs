using NST.Abstractions;
using NST.DBConnector;
using NST.DomainModel;
using System;

namespace NST.ClassicWiring
{
    public class OrderService
    {
        private IOrderSaver orderSaver;

        public OrderService()
        {
            this.orderSaver = new DBOrderSaver();
        }

        public void AcceptOrder(Order order)
        {
            orderSaver.Save(order);
        }
    }
}
