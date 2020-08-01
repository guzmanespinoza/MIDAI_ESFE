using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidaiEsfe.Aplicacion.AccesoADatos;
using MidaiEsfe.Aplicacion.EntidadesDeNegocio;

namespace MidaiEsfe.Aplicacion.LogicaDeNegocio
{
    public class TipoPersonaBL
    {
        public static int Guardar (TipoPersona pTipoPersona)
        {
        return TipoPersonaDAL.Guardar(pTipoPersona);
        }
        public static int Modificar(TipoPersona pTipoPersona)
        {
            return TipoPersonaDAL.Modificar(pTipoPersona);
        }
        public static int Eliminar (TipoPersona pTipoPersona)
        {
            return TipoPersonaDAL.Eliminar(pTipoPersona);
        }
        public static List<TipoPersona> ObtenerTodos()
        {
            return TipoPersonaDAL.ObtenerTodos();
        }
        public static TipoPersona BuscarPorId(byte pId)
        {
            return TipoPersonaDAL.BuscarPorId(pId);
        }
    }

}
