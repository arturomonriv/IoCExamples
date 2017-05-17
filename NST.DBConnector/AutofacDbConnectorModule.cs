using Autofac;
using NST.Abstractions;
using NST.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NST.DBConnector
{
    public class AutofacDbConnectorModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DBOrderSaver>()
                .As<IOrderSaver>()
                .Keyed<IOrderSaver>(ConnectorType.Db)
                .InstancePerLifetimeScope();
        }
    }
}
