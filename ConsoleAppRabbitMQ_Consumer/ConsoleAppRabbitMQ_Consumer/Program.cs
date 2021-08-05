using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace ConsoleAppRabbitMQ_Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            //Console.ForegroundColor = ConsoleColor.Red;
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
                    Console.WriteLine("Consumindo...");
                    while (true)
                    {
                        var consumer = new EventingBasicConsumer(channel);
                        consumer.Received += (model, ea) =>
                        {
                            var body = ea.Body.Span;
                            var message = Encoding.UTF8.GetString(body);
                            Console.WriteLine("Mensagem recebida:{0}", message);
                        };
                        channel.BasicConsume(queue: "FilaRabbitMQ",
                            autoAck: true,
                            consumer: consumer);                        
                    }

                    //Console.WriteLine("Consumer Funcionando!");
                }
                //Console.ReadLine();
            }
        }
    }
}
