using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using MicroserviceRabbitMQ.Domain.Core.Bus;
using MicroserviceRabbitMQ.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroserviceRabbitMQ.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
