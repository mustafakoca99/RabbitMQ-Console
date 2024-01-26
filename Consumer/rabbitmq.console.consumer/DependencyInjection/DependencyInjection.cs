using Microsoft.Extensions.DependencyInjection;
using rabbitmq.console.consumer.services;

namespace rabbitmq.console.consumer.DependencyInjection
{
    public class DependencyInjection
    {
        public static ServiceProvider Configure()
        {
            return new ServiceCollection()
                .AddScoped<IRabbitMQServices, RabbitMQServices>()
                .BuildServiceProvider();
        }
    }
}
