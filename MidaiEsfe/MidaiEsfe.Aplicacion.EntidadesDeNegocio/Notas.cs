using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidaiEsfe.Aplicacion.EntidadesDeNegocio
{
    public class Notas
    {
        public byte Id { get; set; }

        public byte IdEvaluacion { get; set; }

        public byte IdAsignacionDeModulo { get; set; }

        public byte Nota { get; set; }
    }
}
