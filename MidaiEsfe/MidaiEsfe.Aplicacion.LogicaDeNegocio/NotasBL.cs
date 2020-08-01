using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidaiEsfe.Aplicacion.AccesoADatos;
using MidaiEsfe.Aplicacion.EntidadesDeNegocio;

namespace MidaiEsfe.Aplicacion.LogicaDeNegocio
{
     public class NotasBL
    {
        public static int Guardar(Notas pNotas)
        {
            return NotasDAL.Guardar(pNotas);
        }
        public static int Modificar(Notas pNotas)
        {
            return NotasDAL.Modificar(pNotas);
        }
        public static int Eliminar(Notas pNotas)
        {
            return NotasDAL.Eliminar(pNotas);
        }
        public static List<Notas> ObtenerTodos()
        {
            return NotasDAL.ObtenerTodos();
        }
        public static Notas BuscarPorId(byte pId)
        {
            return NotasDAL.BuscarPorId(pId);
        }
    }
}
