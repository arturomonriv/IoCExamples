using NST.Abstractions;
using NST.DomainModel;
using System;

namespace NST.WiringUsingServiceLocator
{
    public class OrderService
    {
        private IOrderSaver orderSaver;

        public OrderService()
        {
            this.orderSaver = Locator.Resolve<IOrderSaver>();
        }

        public void AcceptOrder(Order order)
        {
            orderSaver.Save(order);
        }
    }
}
