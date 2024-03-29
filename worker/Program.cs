﻿using System.Formats.Asn1;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

var factory = new ConnectionFactory();
factory.HostName="localhost";
var connection = factory.CreateConnection();
var channel = connection.CreateModel();

var consumer = new EventingBasicConsumer(channel);
consumer.Received+=(model,ea)=>{
    Thread.Sleep(2000);
var body = ea.Body.ToArray();
var message= Encoding.UTF8.GetString(body);
channel.BasicAck(ea.DeliveryTag, multiple:false);
Console.WriteLine("Gelen Mesaj:"+message);

};

channel.BasicConsume(queue:"hello",autoAck:false, consumer:consumer);
Console.ReadKey();