using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MidaiEsfe.Aplicacion.EntidadesDeNegocio;

namespace MidaiEsfe.Aplicacion.AccesoADatos
{
    public class NotasDAL
    {
        public static int Guardar(Notas pNotas)
        {
            string consulta = "INSERT INTO Notas (IdEvaluacion, IdAsignacionDeModulo, Nota) values(@Evaluacion, @IdAsignacionDeModulo, @Nota)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Evaluacion", pNotas.IdEvaluacion);
            comando.Parameters.AddWithValue("@IdAsignacionDeModulo", pNotas.IdAsignacionDeModulo);
            comando.Parameters.AddWithValue("@Nota", pNotas.Nota);

            return ComunDB.EjecutarComando(comando);
        }
        public static int Modificar(Notas pNotas)
        {
            string consulta = "UPDATE Notas SET IdEvaluacion=@IdEvaluacion, IdAsignacionDeModulo=@IdAsignacionDeModulo, Nota=@Nota WHERE Id=@Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdEvaluacion", pNotas.IdEvaluacion);
            comando.Parameters.AddWithValue("@IdAsignacionDeModulo", pNotas.IdAsignacionDeModulo);
            comando.Parameters.AddWithValue("@Nota", pNotas.Nota);
            comando.Parameters.AddWithValue("@Id", pNotas.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Eliminar(Notas pNotas)
        {
            string consulta = "DELETE FROM Notas WHERE Id=@Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pNotas.Id);

            return ComunDB.EjecutarComando(comando);
        }
        public static List<Notas> ObtenerTodos()
        {
            String consulta = "SELECT TOP 500 n.Id, n.IdEvaluacion, n.IdAsignacionDeModulo, n.Nota FROM Notas n";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Notas> listaNotas = new List<Notas>();
            while (reader.Read())
            {
                Notas Notas = new Notas();
                Notas.Id = reader.GetByte(0);
                Notas.IdEvaluacion = reader.GetByte(1);
                Notas.IdAsignacionDeModulo = reader.GetByte(2);
                Notas.Nota = reader.GetByte(3);
                listaNotas.Add(Notas);
            }
            return listaNotas;
        }
        public static Notas BuscarPorId(byte pId)
        {
            string consulta = "SELECT n.Id, e.IdEvaluacion, n.IdAsignacionDeModulo, n.Nota FROM Notas n WHERE Id = @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Notas Notas = new Notas();
            while (reader.Read())
            {
                Notas.Id = reader.GetByte(0);
                Notas.IdEvaluacion = reader.GetByte(1);
                Notas.IdAsignacionDeModulo = reader.GetByte(2);
                Notas.Nota = reader.GetByte(3);
            }
            return Notas;
        }
    }
}
