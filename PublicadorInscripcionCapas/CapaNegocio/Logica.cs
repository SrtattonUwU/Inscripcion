using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Logica
    {
        public Adaptador Adaptador;

        public Logica(Adaptador adaptador)
        {
            this.Adaptador = adaptador;
        }

        public bool enviarInscripcionParaInscribirse(InscripcionDTO inscripcion)
        {
            return this.Adaptador.EnviarInscripcion(inscripcion);
        }
    }
}
