using NST.Abstractions;
using System;
using System.Collections.Generic;

namespace NST.WiringUsingFactory
{
    public class OrderServiceFactory
    {
        public static IOrderSaver Get(ConnectorType connectorType)
        {
            switch (connectorType)
            {
                case ConnectorType.DB:
                    return new DBConnector.DBOrderSaver();
                case ConnectorType.XML:
                    return new XMLConnector.XMLOrderSaver();
                default:
                    throw new NotSupportedException(nameof(connectorType));
            }
        }
    }
}
