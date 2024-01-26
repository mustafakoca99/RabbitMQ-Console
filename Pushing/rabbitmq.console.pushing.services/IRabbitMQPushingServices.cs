namespace rabbitmq.console.pushing.services
{
    public interface IRabbitMQPushingServices
    {
        void BasicPushing(string queueName, string message, IEnumerable<int> numberList);
    }
}
