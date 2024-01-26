using Microsoft.Extensions.DependencyInjection;
using rabbitmq.console.pushing.services;

namespace rabbitmq.console.pushing.DependencyInjection
{
    public class DependencyInjection
    {
        public static ServiceProvider Configure()
        {
            return new ServiceCollection()
                .AddScoped<IRabbitMQPushingServices, RabbitMQPushingServices>()
                .BuildServiceProvider();
        }
    }
}
