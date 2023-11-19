using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquipoProgramacionEPF.Dominio;
using EquipoProgramacionEPF.Datos.Interfaz;

namespace EquipoProgramacionEPF.Datos.Implementacion
{
   internal class PartidoEstadisticaDAO: IDaoPartidoEstadistica
    {
        public int Crear(Partidos partidos)
        {
            SqlConnection connection = DBHelperDao.getInstance().GetConnection();
            SqlTransaction t = null;
            int PartidoNro = 0;

            try
            {
                connection.Open();
                t = connection.BeginTransaction();
                SqlCommand sqlCommand = new SqlCommand("InsertarPartido", connection, t);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue(@"Fecha", partidos.FechaPartido);
                sqlCommand.Parameters.AddWithValue(@"EquipoLocal", partidos.ClubLocal);
                sqlCommand.Parameters.AddWithValue(@"Adversario", partidos.ClubVisitante);
                sqlCommand.Parameters.AddWithValue(@"id_temporada", partidos.TemporadaPartido);
                sqlCommand.Parameters.AddWithValue(@"goles_local", partidos.GolesLocal);
                sqlCommand.Parameters.AddWithValue(@"goles_visitantes", partidos.GolesVisitante);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@IDPartido";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(parameter);

                sqlCommand.ExecuteNonQuery();

                PartidoNro = Convert.ToInt32(parameter.Value);


                int NroEstadisticaPartido = 1;
                SqlCommand cmdDetalle;

                foreach (EstadisticaPartido e in partidos.lEstadisticaPartidos)
                {
                    cmdDetalle = new SqlCommand("NombreSP", connection, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue(@"IDPartido", partidos.IdPartido);
                    cmdDetalle.Parameters.AddWithValue(@"IDJUGADOR", e.Jugador);
                    cmdDetalle.Parameters.AddWithValue(@"goles", partidos.IdPartido);
                    cmdDetalle.Parameters.AddWithValue(@"asistencias", partidos.IdPartido);
                    cmdDetalle.Parameters.AddWithValue(@"amarillas", partidos.IdPartido);
                    cmdDetalle.Parameters.AddWithValue(@"rojas", partidos.IdPartido);
                    cmdDetalle.Parameters.AddWithValue(@"TiempoJugado", partidos.IdPartido);
                    cmdDetalle.Parameters.AddWithValue(@"ID_estadistica", NroEstadisticaPartido);

                    cmdDetalle.ExecuteNonQuery();
                    NroEstadisticaPartido++;

                }
                t.Commit();
            }
            catch
            {
                if (t != null) t.Rollback();
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open) { connection.Close(); }
            }
            return PartidoNro;
        }

        public DataTable GetDT(string nombreSP)
        {
            return DBHelperDao.getInstance().ConsultarSP(nombreSP);
        }

        public List<Jugador> GetJugadores()
        {
            List<Jugador> lJugadores = new List<Jugador>();

            DataTable dt = DBHelperDao.getInstance().ConsultarSP("ConsultarJugadores");
            foreach (DataRow dr in dt.Rows)
            {
                int Id = Convert.ToInt32(dr["IDjugador"]);
                string nom = (dr["nombre"]).ToString();
                string ape = (dr["apellido"]).ToString();
                int num = Convert.ToInt32(dr["NumeroCamiseta"]);



                Jugador jugador = new Jugador(Id, nom, ape, num);
                lJugadores.Add(jugador);

            }
            return lJugadores;
        }

        public bool CrearJugador(Jugador oJugador)
        {
            bool resultado = true;
            SqlTransaction transaccion = null;
            SqlConnection conexion = DBHelperDao.getInstance().GetConnection();
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_JUGADOR", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", oJugador.Nombre);
                comando.Parameters.AddWithValue("@Apellido", oJugador.Apellido);
                comando.Parameters.AddWithValue("@Club", oJugador.club.Id);
                comando.Parameters.AddWithValue("@Posicion", oJugador.posicion.idPosicion);
                comando.Parameters.AddWithValue("@NumeroCamiseta", oJugador.Numero);
                comando.Parameters.AddWithValue("@Nacionalidad", oJugador.pais.IdPais);
                comando.Parameters.AddWithValue("@FechaNacimiento", oJugador.FechaNacimiento);
                comando.Parameters.AddWithValue("@Altura", oJugador.Altura);
                comando.Parameters.AddWithValue("@Peso", oJugador.Peso);
                comando.ExecuteNonQuery();
                transaccion.Commit();

            }
            catch
            {
                if (transaccion != null)
                {
                    transaccion.Rollback();
                    resultado = false;
                }
            }
            finally
            {
                if (conexion != null) conexion.Close();
            }
            return resultado;
        }
        
        public List<Pais> GetPais()
        {
            List<Pais> lPaises = new List<Pais>();
            DataTable tabla = DBHelperDao.getInstance().ConsultarSP("SP_CONSULTAR_PAIS");
            foreach (DataRow fila in tabla.Rows)
            {
                int codigo = int.Parse(fila["id_pais"].ToString());
                string nombre = fila["nombrePais"].ToString();
                Pais c = new Pais(codigo, nombre);
                lPaises.Add(c);
            }
            return lPaises;
        }

        public List<Posicion> GetPosicion()
        {
            List<Posicion> lPosiciones = new List<Posicion>();
            DataTable tabla = DBHelperDao.getInstance().ConsultarSP("SP_CONSULTAR_POSICION");
            foreach (DataRow fila in tabla.Rows)
            {
                int codigo = int.Parse(fila["IDPosicion"].ToString());
                string nombre = fila["NombrePosicion"].ToString();
                Posicion c = new Posicion(codigo, nombre);
                lPosiciones.Add(c);
            }
            return lPosiciones;
        }

        public List<Club> GetClub()
        {
            List<Club> lClubes = new List<Club>();
            DataTable tabla = DBHelperDao.getInstance().ConsultarSP("SP_CONSULTAR_CLUB");
            foreach (DataRow fila in tabla.Rows)
            {
                int codigo = int.Parse(fila["IDClub"].ToString());
                string nombre = fila["NombreClub"].ToString();
                Club c = new Club(codigo,nombre);
                lClubes.Add(c);
            }
            return lClubes;
        }
        public List<Jugador> TraerJugadores(List<Parametro> lParams, string nombreSP)
        {
            DataTable tabla = DBHelperDao.getInstance().Consultar(nombreSP, lParams);
            List<Jugador> lJugador = new List<Jugador>();
            Club club = new Club();
            foreach (DataRow r in tabla.Rows)
            {
                int id = int.Parse(r["IDJugador"].ToString());
                string nombre = r["Nombre"].ToString();
                string Apellido = r["Apellido"].ToString();
                lJugador.Add(new Jugador(id,nombre,Apellido));
            }
            return lJugador;
        }
        public Jugador TraerJugador(int nroJugador)
        {
            Jugador jugador = new Jugador();
            SqlConnection conexion = DBHelperDao.getInstance().GetConnection();
            SqlCommand comando = new SqlCommand();
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_CONSULTAR_JUGADOR";
            Parametro param = new Parametro("@IDJugador", nroJugador);
            comando.Parameters.AddWithValue(param.Nombre, param.Valor);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            jugador.IdJugador = nroJugador;
            foreach (DataRow fila in tabla.Rows)
            {
                jugador.IdJugador = int.Parse(fila["IDJugador"].ToString());
                jugador.Nombre = fila["Nombre"].ToString();
                jugador.Apellido = fila["Apellido"].ToString();
            }
            
            return jugador;
        }

        public bool ActualizarJugador(Jugador oJugador)
        {
            bool aux = true;
            //Creamos la transaccion como nula
            SqlTransaction transaccion = null;
            SqlConnection conexion = DBHelperDao.getInstance().GetConnection();
            try
            {
                conexion.Open();
                //Abro la conexion y despues abro la transaccion bajo esa conexion!
                transaccion = conexion.BeginTransaction();
                //Al crear el comando le pasamos x parametro: el string del comando, la conexion y la transaccion
                
                SqlCommand comando = new SqlCommand("SP_ACTUALIZAR_JUGADOR", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDJugador", oJugador.IdJugador);
                comando.Parameters.AddWithValue("@Nombre", oJugador.Nombre);
                comando.Parameters.AddWithValue("@Apellido", oJugador.Apellido);
                comando.Parameters.AddWithValue("@Club", oJugador.club.Id);
                comando.Parameters.AddWithValue("@Posicion", oJugador.posicion.idPosicion);
                comando.Parameters.AddWithValue("@NumeroCamiseta", oJugador.Numero);
                comando.Parameters.AddWithValue("@Nacionalidad", oJugador.pais.IdPais);
                comando.Parameters.AddWithValue("@FechaNacimiento", oJugador.FechaNacimiento);
                comando.Parameters.AddWithValue("@Altura", oJugador.Altura);
                comando.Parameters.AddWithValue("@Peso", oJugador.Peso);
                comando.ExecuteNonQuery();
                transaccion.Commit();
            }
            catch
            {
                if (transaccion != null)
                {
                    transaccion.Rollback();
                    aux = false;
                }
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return aux;
        }

        public bool BorrarJugador(int nroJugador)
        {
            bool aux = true;
            SqlConnection conexion = DBHelperDao.getInstance().GetConnection();
            SqlTransaction transaccion = null;
            
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("SP_BORRAR_JUGADOR", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                Parametro param = new Parametro("@IDJugador", nroJugador);
                comando.Parameters.AddWithValue(param.Nombre,param.Valor);
                comando.ExecuteNonQuery();
                transaccion.Commit();
            conexion.Close();
            return aux;
        }
    }
}

