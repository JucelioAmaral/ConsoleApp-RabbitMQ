using RabbitMQ.Client;
using System;
using System.Text;

namespace ConsoleAppRabbitMQ_Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "FilaRabbitMQ",
                        durable: false,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null);

                    int cont = 0;
                    while (true)
                    {
                        string message = $"{cont += 1} - Envio de mensagem RAbbitMQ!";
                        var body = Encoding.UTF8.GetBytes(message);

                        channel.BasicPublish(exchange: "",
                            routingKey: "FilaRabbitMQ",
                            basicProperties: null,
                            body: body);

                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Mensagem Enviada: {0}", message);
                        System.Threading.Thread.Sleep(5000);
                    }
                }
                //Console.ReadLine();
            }
        }
    }
}
