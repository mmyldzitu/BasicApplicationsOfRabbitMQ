// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Reflection.Metadata.Ecma335;
using System.Text;
using RabbitMQ.Client;
var facory = new ConnectionFactory();
facory.HostName="localhost";
var connection = facory.CreateConnection();
var channel = connection.CreateModel();

static string GetMessage(string[] args){

    return args.Length>0? string.Join(" ",args):"HelloWorld";
}
var message = GetMessage(args);
int dots = message.Split(".").Length-1;
Thread.Sleep(dots*1000);
channel.QueueDeclare(queue:"hello",durable:false,exclusive:false, autoDelete:false,arguments:null);
channel.BasicPublish(exchange:string.Empty, routingKey:"hello",basicProperties:null, body:Encoding.UTF8.GetBytes(message));