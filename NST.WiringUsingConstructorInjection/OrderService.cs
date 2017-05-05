using NST.Abstractions;
using NST.DomainModel;
using System;

namespace NST.WiringUsingConstructorInjection
{
    public class OrderService
    {
        private IOrderSaver orderSaver;

        public OrderService(IOrderSaver orderSaver)
        {
            this.orderSaver = orderSaver;
        }

        public void AcceptOrder(Order order)
        {
            orderSaver.Save(order);
        }
    }
}
