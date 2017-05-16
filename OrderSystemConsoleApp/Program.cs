using Autofac;
using NST.Abstractions;
using System;

namespace OrderSystemConsoleApp
{
    class Program
    {
        private static IContainer AppContainer { get; set; }

        static void Main(string[] args)
        {
            try
            {
                InitializeContainer();

                CommandConfig config = ConfigureCommand(args);

                var orderSystem = AppContainer.Resolve<IOrderService>();
                orderSystem.Configure(config.ConnectorType);
                orderSystem.AddOrder(config.Data);
            }
            catch (Exception MainExc)
            {
                throw MainExc;
            }
        }

        private static CommandConfig ConfigureCommand(string[] args)
        {
            throw new NotImplementedException();
        }

        private static void InitializeContainer()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<OrderService>()
                .As<IOrderService>()
                .InstancePerLifetimeScope();

            AppContainer = containerBuilder.Build();
        }
    }
}