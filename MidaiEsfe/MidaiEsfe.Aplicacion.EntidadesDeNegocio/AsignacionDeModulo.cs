﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidaiEsfe.Aplicacion.EntidadesDeNegocio
{
     public  class AsignacionDeModulo
    {
        public byte Id { get; set; }

        public byte IdPersona { get; set; }

        public byte IdModulo { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}
