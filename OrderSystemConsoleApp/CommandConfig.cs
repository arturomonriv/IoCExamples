using NST.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystemConsoleApp
{
    public class CommandConfig
    {
        public ConnectorType ConnectorType { get; set; }

        public Order Data { get; set; }
    }
}
