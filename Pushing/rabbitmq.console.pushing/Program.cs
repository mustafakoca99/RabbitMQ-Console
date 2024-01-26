
using Microsoft.Extensions.DependencyInjection;
using rabbitmq.console.pushing.DependencyInjection;
using rabbitmq.console.pushing.services;

var serviceProvider = DependencyInjection.Configure();
var rabbitMQ = serviceProvider.GetRequiredService<IRabbitMQPushingServices>();
rabbitMQ.BasicPushing("my-test-queue", "hello RabbitMQ", new List<int> { 1, 9 }); //queue messajı gönder