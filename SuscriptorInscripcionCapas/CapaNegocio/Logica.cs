using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Logica
    {
        private FuenteDatos repositorio;

        public Logica(FuenteDatos repositorio)
        {
            this.repositorio = repositorio;
        }

        public bool GuardarInscripcion(InscripcionDTO inscripcion)
        {
            return this.repositorio.GuardarInscripcion(inscripcion);
        }
    }
}
