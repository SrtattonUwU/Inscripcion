using CapaAccesoDatos;
using CapaNegocio;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

ConnectionFactory factory = new ConnectionFactory
{
    HostName = "moose-01.rmq.cloudamqp.com",
    UserName = "csqkrots",
    Password = "BVtzpOgypPvBrRpm1IjvZti1kXY1P0IH",
    VirtualHost = "csqkrots",
    Port = 5672
};

IConnection connection = await factory.CreateConnectionAsync();
IChannel channel = await connection.CreateChannelAsync();

Console.WriteLine(" [*] Esperando mensajes");

AsyncEventingBasicConsumer consumer = new AsyncEventingBasicConsumer(channel);
consumer.ReceivedAsync += (model, ea) =>
{
    byte[] body = ea.Body.ToArray();
    string message = Encoding.UTF8.GetString(body);
    Console.WriteLine($" [x] {message}");

    InscripcionDTO inscripcion = JsonConvert.DeserializeObject<InscripcionDTO>(message);
    Logica logica = new Logica(new ConexionBaseDatosRelacional());
    logica.GuardarInscripcion(inscripcion);

    return Task.CompletedTask;
};

await channel.BasicConsumeAsync("estudio", autoAck: true, consumer: consumer);

Console.WriteLine(" Press [enter] to exit.");
Console.ReadLine();