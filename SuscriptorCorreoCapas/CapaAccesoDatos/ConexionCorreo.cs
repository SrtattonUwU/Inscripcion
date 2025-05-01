using System;
using System.Net;
using Newtonsoft.Json;
using System.Net.Mail;
using CapaNegocio;

namespace CapaAccesoDatos
{
    public class ConexionCorreo : FuenteDatos
    {
        public bool EnviarInscripcion(InscripcionDTO inscripcion)
        {
            try
            {
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress("montarrietasantibastian@gmail.com"); 
                correo.To.Add("arrietaospina783@gmail.com");
                correo.Subject = "Esta es la inscripcion";
                string cuerpo = $"Hola,\n\nSe ha recibido una nueva inscripción:\n\n" +
                            $"Nombre: {inscripcion.Name}\n" +
                            $"Apellido: {inscripcion.LastName}\n" +
                            $"Documento: {inscripcion.NroDocumento}\n" +
                            $"Carrera de interés: {inscripcion.CarreraInteres}\n\n" +
                            $"Bienaventurados aquellos que han recibido de forma exitosa el detalle de inscripcion";
                correo.Body = cuerpo;

                correo.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("montarrietasantibastian@gmail.com", "edda fllh uawm bwpr"); 
                smtp.EnableSsl = true;

                smtp.Send(correo);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool EnviarCorreo(InscripcionDTO inscripcion)
        {
            return EnviarInscripcion(inscripcion);
        }
    }

}