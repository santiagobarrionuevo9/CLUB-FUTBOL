using EquipoProgramacionEPF.Datos;
using EquipoProgramacionEPF.Datos.Implementacion;
using EquipoProgramacionEPF.Datos.Interfaz;
using EquipoProgramacionEPF.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoProgramacionEPF.Servicios
{
    internal class Servicio : IServicio
    {
        private IDaoPartidoEstadistica DAO;

        public Servicio()
        {
            DAO = new PartidoEstadisticaDAO();
        }
        public int Crear(Partidos partido)
        {
            return DAO.Crear(partido);
        }

        public DataTable GetDT(string nombreSP)
        {
            return DAO.GetDT(nombreSP);
        }

        public List<Jugador> GetJugadores()
        {
            return DAO.GetJugadores();
        }

        public bool CrearJugador(Jugador oJugador)
        {
            return DAO.CrearJugador(oJugador);
        }
        public List<Pais> GetPais()
        {
            return DAO.GetPais();
        }
        public List<Club> GetClub()
        {
            return DAO.GetClub();
        }
        public List<Posicion> GetPosicion()
        {
            return DAO.GetPosicion();
        }
        
        public List<Jugador> TraerJugadores(List<Parametro> lParams, string nombreSP)
        {
            return DAO.TraerJugadores(lParams, nombreSP);
        }
        public bool ActualizarJugador(Jugador oJugador)
        {
            return DAO.ActualizarJugador(oJugador);
        }
        public bool BorrarJugador(int nroJugador)
        {
            return DAO.BorrarJugador(nroJugador);
        }
        public Jugador TraerJugador(int nroJugador)
        {
            return DAO.TraerJugador(nroJugador);
        }
    }
}
