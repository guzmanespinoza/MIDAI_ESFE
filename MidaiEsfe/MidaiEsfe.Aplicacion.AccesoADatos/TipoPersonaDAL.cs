using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MidaiEsfe.Aplicacion.EntidadesDeNegocio;

namespace MidaiEsfe.Aplicacion.AccesoADatos
{
    public class TipoPersonaDAL
    {
        public static int Guardar(TipoPersona pTipoPersona)
        {
            string consulta = "INSERT INTO TipoPersona(Nombre) values(@Nombre)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Nombre", pTipoPersona.Nombre);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Modificar(TipoPersona pTipoPersona)
        {
            string consulta = "UPDATE TipoPersona SET Nombre= @Nombre WHERE Id=@Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Nombre", pTipoPersona.Nombre);
            comando.Parameters.AddWithValue("@Id", pTipoPersona.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Eliminar(TipoPersona pTipoPersona)
        {
            string consulta = "DELETE FROM TipoPersona WHERE Id=@Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pTipoPersona.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static List <TipoPersona> ObtenerTodos()
        {
            String consulta = "SELECT TOP 500 t.Id, t.Nombre FROM TipoPersona t";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<TipoPersona> listaTipoPersona = new List<TipoPersona>();
            while (reader.Read())
            {
                TipoPersona TipoPersona = new TipoPersona();
                TipoPersona.Id = reader.GetByte(0);
                TipoPersona.Nombre = reader.GetString(1);
                listaTipoPersona.Add(TipoPersona);
            }
            return listaTipoPersona;
        }
        public static TipoPersona BuscarPorId(byte pId)
        {
            string consulta = "SELECT t.Id, t.Nombre FROM TipoPersona t WHERE Id = @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            TipoPersona TipoPersona = new TipoPersona();
            while (reader.Read())
            {
                TipoPersona.Id = reader.GetByte(0);
                TipoPersona.Nombre = reader.GetString(1);
            }
            return TipoPersona;
        }
    }
}
