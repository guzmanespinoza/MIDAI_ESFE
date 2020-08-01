using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidaiEsfe.Aplicacion.AccesoADatos;
using MidaiEsfe.Aplicacion.EntidadesDeNegocio;

namespace MidaiEsfe.Aplicacion.LogicaDeNegocio
{
    class ModuloBL
    {
        public static int Guardar(Modulo pModulo)
        {
            return ModuloDAL.Guardar(pModulo);
        }
        public static int Modificar(Modulo pModulo)
        {
            return ModuloDAL.Modificar(pModulo);
        }
        public static int Eliminar(Modulo pModulo)
        {
            return ModuloDAL.Eliminar(pModulo);
        }
        public static List<Modulo> ObtenerTodos()
        {
            return ModuloDAL.ObtenerTodos();
        }
        public static Modulo BuscarPorId(byte pId)
        {
            return ModuloDAL.BuscarPorId(pId);
        }
    }
}
