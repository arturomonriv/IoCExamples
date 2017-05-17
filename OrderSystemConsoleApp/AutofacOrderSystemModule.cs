using Autofac;
using NST.Abstractions;
using NST.DomainModel;
using System;

namespace OrderSystemConsoleApp
{
    public class AutofacOrderSystemModule : Module
    {
        public ConnectorType DefaultConnector { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OrderService>()
                .As<IOrderService>()
                .WithParameter("connectorType", DefaultConnector)
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
