using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MidaiEsfe.Aplicacion.EntidadesDeNegocio;

namespace MidaiEsfe.Aplicacion.AccesoADatos
{
    public class AsignacionDeModuloDAL
    {
        public static int Guardar(AsignacionDeModulo pAsignacionDeModulo)
        {
            string consulta = "INSERT INTO AsignacionDeModulo (IdPersona,IdModulo, FechaRegistro) values(@IdPersona, @IdModulo, @FechaRegistro)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdPersona", pAsignacionDeModulo.IdPersona);
            comando.Parameters.AddWithValue("@IdModulo", pAsignacionDeModulo.IdModulo);
            comando.Parameters.AddWithValue("@FechaRegistro", pAsignacionDeModulo.FechaRegistro);

            return ComunDB.EjecutarComando(comando);
        }
        public static int Modificar(AsignacionDeModulo pAsignacionDeModulo)
        {
            string consulta = "UPDATE AsignacionDeModulo SET IdPersona=@IdPersona, IdModulo=@IdModulo, FechaRegistro=@FechaRegistro WHERE Id=@Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdPersona", pAsignacionDeModulo.IdPersona);
            comando.Parameters.AddWithValue("@IdModulo", pAsignacionDeModulo.IdModulo);
            comando.Parameters.AddWithValue("@FechaRegistro", pAsignacionDeModulo.FechaRegistro);
            comando.Parameters.AddWithValue("@Id", pAsignacionDeModulo.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Eliminar(AsignacionDeModulo pAsignacionDeModulo)
        {
            string consulta = "DELETE FROM AsignacionDeModulo WHERE Id=@Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pAsignacionDeModulo.Id);

            return ComunDB.EjecutarComando(comando);
        }
        public static List<AsignacionDeModulo> ObtenerTodos()
        {
            String consulta = "SELECT TOP 500 a.Id, a.IdPersona, a.IdModulo, a.FechaRegistro FROM AsignacionDeModulo a";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<AsignacionDeModulo> listaAsignacionDeModulo = new List<AsignacionDeModulo>();
            while (reader.Read())
            {
                AsignacionDeModulo AsignacionDeModulo = new AsignacionDeModulo();
                AsignacionDeModulo.Id = reader.GetByte(0);
                AsignacionDeModulo.IdPersona = reader.GetByte(1);
                AsignacionDeModulo.IdModulo = reader.GetByte(2);
                AsignacionDeModulo.FechaRegistro = reader.GetDateTime(3);
                listaAsignacionDeModulo.Add(AsignacionDeModulo);
            }
            return listaAsignacionDeModulo;
        }
        public static AsignacionDeModulo BuscarPorId(byte pId)
        {
            string consulta = "SELECT a.Id, a.IdPersona, a.IdModulo, a.FechaRegistro FROM AsignacionDeModulo a WHERE Id = @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            AsignacionDeModulo AsignacionDeModulo = new AsignacionDeModulo();
            while (reader.Read())
            {
                AsignacionDeModulo.Id = reader.GetByte(0);
                AsignacionDeModulo.IdPersona = reader.GetByte(1);
                AsignacionDeModulo.IdModulo = reader.GetByte(2);
                AsignacionDeModulo.FechaRegistro = reader.GetDateTime(3);
            }
            return AsignacionDeModulo;
        }
    }
}
