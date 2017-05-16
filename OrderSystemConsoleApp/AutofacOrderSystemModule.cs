using Autofac;
using NST.Abstractions;
using NST.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystemConsoleApp
{
    public class AutofacOrderSystemModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OrderService>()
                .As<IOrderService>()
                .InstancePerLifetimeScope();

            builder.Register<Func<ConnectorType, IOrderSaver>>(c =>
            {
                var componentContext = c.Resolve<IComponentContext>();
                return (reportType) => {
                    return componentContext.ResolveKeyed<IOrderSaver>(reportType);
                };
            }).InstancePerLifetimeScope();
        }
    }
}
