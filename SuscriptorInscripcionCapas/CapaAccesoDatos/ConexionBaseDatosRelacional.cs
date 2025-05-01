using CapaNegocio;
using Npgsql;

namespace CapaAccesoDatos
{
    public class ConexionBaseDatosRelacional : FuenteDatos
    {
        public bool ConexionMYSQL(InscripcionDTO inscripcion)
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=holamundo;Database=inscripciones;";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO public.datos (name, lastname, nrodocumento, carrera) " +
                                   "VALUES (@Name, @LastName, @NroDocumento, @CarreraInteres)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("Name", inscripcion.Name);
                        cmd.Parameters.AddWithValue("LastName", inscripcion.LastName);
                        cmd.Parameters.AddWithValue("NroDocumento", inscripcion.NroDocumento);
                        cmd.Parameters.AddWithValue("CarreraInteres", inscripcion.CarreraInteres);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    string er = ex.Message;
                    Console.WriteLine(er);
                    return false;
                }
            }
        }

        public bool GuardarInscripcion(InscripcionDTO inscripcion)
        {
            return ConexionMYSQL(inscripcion);
        }
    }
}