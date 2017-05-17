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
        
        public OrderService(Func<ConnectorType, IOrderSaver> orderSaverFactory, ConnectorType? connectorType)
        {
            OrderSaverFactory = orderSaverFactory;
            Connector = connectorType;
        }
        
        private Func<ConnectorType, IOrderSaver> OrderSaverFactory
        {
            get { return _OrderSaverFactory; }
            set
            {
                _OrderSaverFactory = value ?? throw new ArgumentNullException("Order saver factory cannot be null.");
            }
        }

        private ConnectorType? Connector { get; set; }

        public void AddOrder(Order order)
        {
            ConnectorType defaultConnector = Connector.HasValue ? Connector.Value : ConnectorType.Db;

            IOrderSaver orderSaver = OrderSaverFactory(defaultConnector);

            orderSaver.Save(order);
        }

    }
}
