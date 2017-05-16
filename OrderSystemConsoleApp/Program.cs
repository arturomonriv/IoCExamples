using Autofac;
using NST.Abstractions;
using NST.DBConnector;
using NST.DomainModel;
using NST.XMLConnector;
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
            return new CommandConfig();
        }

        private static void InitializeContainer()
        {
            var builder = new ContainerBuilder();
            RegisterModules(builder);
            AppContainer = builder.Build();
        }

        private static void RegisterModules(ContainerBuilder builder)
        {
            builder.RegisterAssemblyModules<AutofacOrderSystemModule>();
            builder.RegisterAssemblyModules<AutofacDbConnectorModule>();
            builder.RegisterModule<AutofacXmlConnectorModule>();
        }
    }
}