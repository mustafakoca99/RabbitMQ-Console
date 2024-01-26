using Microsoft.Extensions.DependencyInjection;
using rabbitmq.console.consumer.DependencyInjection;
using rabbitmq.console.consumer.services;

var serviceProvider = DependencyInjection.Configure();
var rabbitMQ = serviceProvider.GetRequiredService<IRabbitMQServices>();
rabbitMQ.BasicCostume("my-test-queue"); //queue icinde ki mesajlari oku