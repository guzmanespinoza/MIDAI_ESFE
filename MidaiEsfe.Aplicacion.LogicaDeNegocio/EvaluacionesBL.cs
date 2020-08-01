using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidaiEsfe.Aplicacion.AccesoADatos;
using MidaiEsfe.Aplicacion.EntidadesDeNegocio;

namespace MidaiEsfe.Aplicacion.LogicaDeNegocio
{
    public class EvaluacionesBL
    {
        public static int Guardar(Evaluaciones pEvaluaciones)
        {
            return EvaluacionesDAL.Guardar(pEvaluaciones);
        }
        public static int Modificar(Evaluaciones pEvaluaciones)
        {
            return EvaluacionesDAL.Modificar(pEvaluaciones);
        }
        public static int Eliminar(Evaluaciones pEvaluaciones)
        {
            return EvaluacionesDAL.Eliminar(pEvaluaciones);
        }
        public static List<Evaluaciones> ObtenerTodos()
        {
            return EvaluacionesDAL.ObtenerTodos();
        }
        public static Evaluaciones BuscarPorId(byte pId)
        {
            return EvaluacionesDAL.BuscarPorId(pId);
        }
        }
}
