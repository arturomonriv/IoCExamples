using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NST.DomainModel;

namespace NST.WiringUsingServiceLocator.Tests
{
    [TestClass]
    public class OrderServiceTests
    {
        [TestInitialize]
        public void Initialize_Locator()
        {
            //We set our stubs
            Locator.Register<Abstractions.IOrderSaver>(() => new MyOrderSaver());
        }

        [TestMethod]
        public void OrderService_EnsureWeCanSaveAnOrder_BasicScenario()
        {
            //it hides its dependencies
            OrderService orderService = new OrderService();
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
