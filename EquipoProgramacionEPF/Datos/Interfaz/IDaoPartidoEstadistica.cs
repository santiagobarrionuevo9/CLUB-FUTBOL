using EquipoProgramacionEPF.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoProgramacionEPF.Datos.Interfaz
{
    internal interface IDaoPartidoEstadistica
    {
        int Crear(Partidos compromiso);

        List<Jugador> GetJugadores();
        DataTable GetDT(string nombreSP);
        bool CrearJugador(Jugador oJugador);
        List<Pais> GetPais();
        List<Club> GetClub();
        List<Posicion> GetPosicion();

        List<Jugador> TraerJugadores(List<Parametro> lParams, string nombreSP);
        bool ActualizarJugador(Jugador oJugador);
        bool BorrarJugador(int nroJugador);
        Jugador TraerJugador(int nroJugador);
    }
}
