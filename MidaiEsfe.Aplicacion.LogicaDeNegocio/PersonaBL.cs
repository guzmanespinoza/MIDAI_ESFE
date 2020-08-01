using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidaiEsfe.Aplicacion.AccesoADatos;
using MidaiEsfe.Aplicacion.EntidadesDeNegocio;

namespace MidaiEsfe.Aplicacion.LogicaDeNegocio
{
    public class PersonaBL
    {
        public static int Guardar(Persona pPersona)
        {
            return PersonaDAL.Guardar(pPersona);
        }
        public static int Modificar(Persona pPersona)
        {
            return PersonaDAL.Modificar(pPersona);
        }
        public static int Eliminar(Persona pPersona)
        {
            return PersonaDAL.Eliminar(pPersona);
        }
        public static List<Persona> ObtenerTodos()
        {
            return PersonaDAL.ObtenerTodos();
        }
        public static Persona BuscarPorId(byte pId)
        {
            return PersonaDAL.BuscarPorId(pId);
        }
    }
}
