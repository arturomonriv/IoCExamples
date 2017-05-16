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


        public OrderService(Func<ConnectorType, IOrderSaver> orderSaverFactory)
        {
            OrderSaverFactory = orderSaverFactory;
        }


        
        private Func<ConnectorType, IOrderSaver> OrderSaverFactory
        {
            get { return _OrderSaverFactory; }
            set { _OrderSaverFactory = value; }
        }

        private ConnectorType ConnectorType
        {
            get { return _ConnectorType; }
            set { _ConnectorType = value; }
        }

        public void AddOrder(Order order)
        {
            IOrderSaver orderSaver = OrderSaverFactory(ConnectorType);

            orderSaver.Save(order);
        }

        public void Configure(ConnectorType connectorType)
        {
            ConnectorType = connectorType;
        }
    }
}
