using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NST.DomainModel;

namespace NST.ClassicWiring.Tests
{
    [TestClass]
    public class OrderServiceTests
    {
        [TestMethod]
        public void OrderService_EnsureWeCanSaveAnOrder_BasicScenario()
        {
            ///No way we can create our stub/mock 
            OrderService orderService = new OrderService();
            Order order = new Order();
            orderService.AcceptOrder(order);
        }
    }
}
