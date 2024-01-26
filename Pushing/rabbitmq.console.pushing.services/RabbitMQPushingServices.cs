using RabbitMQ.Client;
using System.Text;

namespace rabbitmq.console.pushing.services
{
    public class RabbitMQPushingServices : IRabbitMQPushingServices
    {
        public void BasicPushing(string queueName, string message, IEnumerable<int> numberList)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);

                foreach (var item in numberList)
                {
                    var body = Encoding.UTF8.GetBytes(item.ToString());
                    channel.BasicPublish(exchange: "", routingKey: queueName, basicProperties: null, body: body);
                }

                var bodyv2 = Encoding.UTF8.GetBytes(message);
                channel.BasicPublish(exchange: "", routingKey: queueName, basicProperties: null, body: bodyv2);
            }
        }
    }
}
