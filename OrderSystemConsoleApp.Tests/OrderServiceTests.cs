using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderSystemConsoleApp;
using Autofac;
using NST.Abstractions;
using NST.DomainModel;
using Moq;

namespace OrderSystemCommandApp.Tests
{
    [TestClass]
    public class OrderServiceTests
    {
        [TestMethod]
        [TestCategory("OrderSystem")]
        public void When_AddingOrder_SaverShouldSaveOrder()
        {
            var orderSaver = new Mock<IOrderSaver>();

            Func<ConnectorType, IOrderSaver> SaverFactory = (type) =>
                {
                    return orderSaver.Object;
                };

            IOrderService orderService = new OrderService(SaverFactory, ConnectorType.Xml);
            var orderItem = new Order() { Id = 2, Name = "OrderXYZ" };

            orderService.AddOrder(orderItem);

            Assert.IsInstanceOfType(orderService, typeof(OrderService));
            orderSaver.Verify(x => x.Save(orderItem));
        }

        [TestMethod]
        [TestCategory("OrderSystem")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void When_InvalidDependencies_MustThrowException()
        {
            IOrderService orderService = new OrderService(null, null);
        }
    }
}
