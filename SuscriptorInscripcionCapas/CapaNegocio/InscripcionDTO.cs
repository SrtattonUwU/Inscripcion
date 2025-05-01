using System.Text.Json;

namespace CapaNegocio
{
    public class InscripcionDTO
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NroDocumento { get; set; }
        public string CarreraInteres { get; set; }

        public InscripcionDTO(string name, string lastName, string nroDocumento, string carreraInteres)
        {
            this.Name = name;
            this.LastName = lastName;
            this.NroDocumento = nroDocumento;
            this.CarreraInteres = carreraInteres;
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(new
            {
                Mensaje = "Inscripción realizada",
                Name = this.Name,
                LastName = this.LastName,
                NroDocumento = this.NroDocumento,
                CarreraInteres = this.CarreraInteres
            });
        }
    }
}
