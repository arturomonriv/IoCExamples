using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NST.DomainModel;

namespace NST.WiringUsingConstructorInjection.Tests
{
    [TestClass]
    public class OrderServiceTests
    {
        [TestMethod]
        public void OrderService_EnsureWeCanSaveAnOrder_BasicScenario()
        {
            Abstractions.IOrderSaver orderSaver = new MyOrderSaver();
            //We inject dependency
            OrderService orderService = new OrderService(orderSaver);
            Order order = new Order();
            orderService.AcceptOrder(order);
        }
    }

    internal class MyOrderSaver : Abstractions.IOrderSaver
    {
        public void Save(Order order)
        {
            //My stubbed Save order method
        }
    }
}
