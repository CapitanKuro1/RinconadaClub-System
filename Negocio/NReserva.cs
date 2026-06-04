using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NReserva
    {
        private DReserva dReserva = new DReserva();

        public string Registrar(Reservas reserva)
        {
            return dReserva.Registrar(reserva);
        }

        public string Modificar(Reservas reserva)
        {
            return dReserva.Modificar(reserva);
        }

        public string Eliminar(int id)
        {
            return dReserva.Eliminar(id);
        }

        public List<Reservas> ListarTodo()
        {
            return dReserva.ListarTodo();
        }

        public Reservas ObtenerPorId(int id)
        {
            return dReserva.ObtenerPorId(id);
        }

        public List<Reservas> BuscarPorSocio(int idSocio)
        {
            return dReserva.BuscarPorSocio(idSocio);
        }

        public List<Reservas> BuscarPorFecha(DateTime fecha)
        {
            return dReserva.BuscarPorFecha(fecha);
        }
    }
}