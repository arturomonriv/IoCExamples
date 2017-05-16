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
        public void When_AddingOrder_SaverShouldSaveOrder()
        {
            var orderSaver = new Mock<IOrderSaver>();

            Func<ConnectorType, IOrderSaver> SaverFactory = (type) =>
                {
                    return orderSaver.Object;
                };

            IOrderService orderService = new OrderService(SaverFactory);

            orderService.Configure(ConnectorType.Db);
            var orderItem = new Order() { Id = 2, Name = "OrderXYZ" };

            orderService.AddOrder(orderItem);

            Assert.IsInstanceOfType(orderService, typeof(OrderService));
            orderSaver.Verify(x => x.Save(orderItem));
        }
    }
}
