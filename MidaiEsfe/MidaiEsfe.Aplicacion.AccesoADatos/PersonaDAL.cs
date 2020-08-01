using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MidaiEsfe.Aplicacion.EntidadesDeNegocio;

namespace MidaiEsfe.Aplicacion.AccesoADatos
{
    public class PersonaDAL
    {
        public static int Guardar(Persona pPersona)
        {
            string consulta = "INSERT INTO Persona(IdTipoPersona, Nombres, Apellidos) values(@IdTipoPersona, @Nombres, @Apellidos)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdTipoPersona", pPersona.IdTipoPersona);
            comando.Parameters.AddWithValue("@Nombres", pPersona.Nombres);
            comando.Parameters.AddWithValue("@Apellidos", pPersona.Apellidos);
            

            return ComunDB.EjecutarComando(comando);
        }
        public static int Modificar(Persona pPersona)
        {
            string consulta = "UPDATE Persona SET IdTipoPersona=@IdTipoPersona, Nombres=@Nombres,Apellidos=@Apellidos WHERE Id=@Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdTipoPersona", pPersona.IdTipoPersona);
            comando.Parameters.AddWithValue("@Nombres", pPersona.Nombres);
            comando.Parameters.AddWithValue("@Apellidos", pPersona.Apellidos);
            comando.Parameters.AddWithValue("@Id", pPersona.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Eliminar(Persona pPersona)
        {
            string consulta = "DELETE FROM Persona WHERE Id=@Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pPersona.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static List<Persona> ObtenerTodos()
        {
            String consulta = "SELECT TOP 500 p.Id, p.IdTipoPersona, p.Nombres, pApellidos FROM Persona p";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Persona> listaPersona = new List<Persona>();
            while (reader.Read())
            {
                Persona Persona = new Persona();
                Persona.Id = reader.GetByte(0);
                Persona.IdTipoPersona = reader.GetByte(1);
                Persona.Nombres = reader.GetString(2);
                Persona.Apellidos = reader.GetString(3);
                listaPersona.Add(Persona);
            }
            return listaPersona;
            }
        public static Persona BuscarPorId(byte pId)
        {
            string consulta = "SELECT p.Id, p.IdTipoPersona, p.Nombres, p.Apellidos FROM Persona p WHERE Id = @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Persona Persona = new Persona();
            while (reader.Read())
            {
                Persona.Id = reader.GetByte(0);
                Persona.IdTipoPersona = reader.GetByte(1);
                Persona.Nombres = reader.GetString(2);
                Persona.Apellidos = reader.GetString(3);
            }
            return Persona;
        }
    }
}
