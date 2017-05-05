using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NST.DomainModel;

namespace NST.WiringUsingFactory.Tests
{
    [TestClass]
    public class OrderServiceTests
    {
        [TestMethod]
        public void OrderService_EnsureWeCanSaveAnOrder_BasicScenario()
        {
            //we can indicate which type but we are tied to supported types
            OrderService orderService = new OrderService(ConnectorType.XML);
            Order order = new Order();
            orderService.AcceptOrder(order);
        }
    }
}
