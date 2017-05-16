using NST.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using NST.DomainModel;

namespace OrderSystemConsoleApp
{
    public class OrderService : IOrderService
    {
        private Func<ConnectorType, IOrderSaver> _OrderSaverFactory;
        private ConnectorType _ConnectorType;
        
        public OrderService(Func<ConnectorType, IOrderSaver> orderSaverFactory, ConnectorType connectorType)
        {
            OrderSaverFactory = orderSaverFactory;
            ConnectorType = connectorType;
        }
        
        private Func<ConnectorType, IOrderSaver> OrderSaverFactory
        {
            get { return _OrderSaverFactory; }
            set { _OrderSaverFactory = value; }
        }

        private ConnectorType ConnectorType { get; set; }

        public void AddOrder(Order order)
        {
            IOrderSaver orderSaver = OrderSaverFactory(ConnectorType);

            orderSaver.Save(order);
        }

    }
}
