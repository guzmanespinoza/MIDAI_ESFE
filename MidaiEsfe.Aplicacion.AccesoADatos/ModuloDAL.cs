using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MidaiEsfe.Aplicacion.EntidadesDeNegocio;

namespace MidaiEsfe.Aplicacion.AccesoADatos
{
    public class ModuloDAL
    {
        public static int Guardar(Modulo pModulo)
        {
            string consulta = "INSERT INTO Modulo(IdPersona, Nombre) values(@IdPersona, @Nombres)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdPersona", pModulo.IdPersona);
            comando.Parameters.AddWithValue("@Nombre", pModulo.Nombre);

            return ComunDB.EjecutarComando(comando);
        }
        public static int Modificar(Modulo pModulo)
        {
            string consulta = "UPDATE Modulo SET IdPersona=@IdPersona, Nombre=@Nombre WHERE Id=@Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdPersona", pModulo.IdPersona);
            comando.Parameters.AddWithValue("@Nombre", pModulo.Nombre);
            comando.Parameters.AddWithValue("@Id", pModulo.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Eliminar(Modulo pModulo)
        {
            string consulta = "DELETE FROM Modulo WHERE Id=@Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pModulo.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static List<Modulo> ObtenerTodos()
        {
            String consulta = "SELECT TOP 500 m.Id, m.IdPersona, m.Nombre FROM Modulo m";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Modulo> listaModulo = new List<Modulo>();
            while (reader.Read())
            {
                Modulo Modulo = new Modulo();
                Modulo.Id = reader.GetByte(0);
                Modulo.IdPersona = reader.GetByte(1);
                Modulo.Nombre = reader.GetString(2);
                listaModulo.Add(Modulo);
            }
            return listaModulo;
        }
        public static Modulo BuscarPorId(byte pId)
        {
            string consulta = "SELECT m.Id, m.IdPersona, m.Nombre FROM Modulo m WHERE Id = @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Modulo Modulo = new Modulo();
            while (reader.Read())
            {
                Modulo.Id = reader.GetByte(0);
                Modulo.IdPersona = reader.GetByte(1);
                Modulo.Nombre = reader.GetString(2);
            }
            return Modulo;
        }
        }
}

