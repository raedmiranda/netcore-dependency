using Autofac;
using Demo.DependencyInjection.Abstractions;
using Demo.DependencyInjection.Implementation1;
using Demo.DependencyInjection.Implementation2;

namespace Demo.DependencyInjection.Application
{
    public static class IoCConfiguration
    {
        public static IContainer GenerateContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Multiplicator2>().As<IMultiplicator>();
            return builder.Build();
        }
    }
}