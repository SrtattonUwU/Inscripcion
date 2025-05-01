using CapaNegocio;
using RabbitMQ.Client;
using System.Text;
using Newtonsoft.Json;

namespace CapaAdaptador
{
    public class AdaptadorRabbit : Adaptador
    {
        private ConnectionFactory factory;
        private IConnection connection;
        private IChannel channel;

        private AdaptadorRabbit() {}

        public static async Task<AdaptadorRabbit> CreateAsync()
        {
            AdaptadorRabbit adapter = new AdaptadorRabbit();

            adapter.factory = new ConnectionFactory
            {
                HostName = "moose-01.rmq.cloudamqp.com",
                UserName = "csqkrots",
                Password = "BVtzpOgypPvBrRpm1IjvZti1kXY1P0IH",
                VirtualHost = "csqkrots",
                Port = 5672
            };

            adapter.connection = await adapter.factory.CreateConnectionAsync();
            adapter.channel = await adapter.connection.CreateChannelAsync();

            return adapter;
        }

        public bool EnviarInscripcion(InscripcionDTO inscripcion)
        {
            string mensaje = JsonConvert.SerializeObject(inscripcion);
            byte[] body = Encoding.UTF8.GetBytes(mensaje);
            channel.BasicPublishAsync(exchange: "carrera.profesion", routingKey: "carrera.estudio", body: body);
            channel.BasicPublishAsync(exchange: "carrera.profesion", routingKey: "carrera.correo", body: body);

            return false;
        }
    }
}
