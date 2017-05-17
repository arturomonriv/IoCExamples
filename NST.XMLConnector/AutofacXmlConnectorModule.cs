using Autofac;
using NST.Abstractions;
using NST.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NST.XMLConnector
{
    public class AutofacXmlConnectorModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<XMLOrderSaver>()
                .As<IOrderSaver>()
                .Keyed<IOrderSaver>(ConnectorType.Xml)
                .InstancePerLifetimeScope();
        }
    }
}
