using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidaiEsfe.Aplicacion.AccesoADatos;
using MidaiEsfe.Aplicacion.EntidadesDeNegocio;

namespace MidaiEsfe.Aplicacion.LogicaDeNegocio
{
    public class AsignacionDeModuloBL
    {
        public static int Guardar(AsignacionDeModulo pAsignacionDeModulo)
        {
            return AsignacionDeModuloDAL.Guardar(pAsignacionDeModulo);
        }
        public static int Modificar(AsignacionDeModulo pAsignacionDeModulo)
        {
            return AsignacionDeModuloDAL.Modificar(pAsignacionDeModulo);
        }
        public static int Eliminar(AsignacionDeModulo pAsignacionDeModulo)
        {
            return AsignacionDeModuloDAL.Eliminar(pAsignacionDeModulo);
        }
        public static List<AsignacionDeModulo> ObtenerTodos()
        {
            return AsignacionDeModuloDAL.ObtenerTodos();
        }
        public static AsignacionDeModulo BuscarPorId(byte pId)
        {
            return AsignacionDeModuloDAL.BuscarPorId(pId);
        }
    }
}
