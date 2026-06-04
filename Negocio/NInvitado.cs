using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NInvitado
    {
        private readonly DInvitado dInvitado = new DInvitado();

        public string Registrar(Invitados i)
        {
            return dInvitado.Registrar(i);
        }

        public string Modificar(Invitados i)
        {
            return dInvitado.Modificar(i);
        }

        public string Eliminar(int id)
        {
            return dInvitado.Eliminar(id);
        }

        public List<Invitados> ListarTodo()
        {
            return dInvitado.ListarTodo();
        }

        public Invitados ObtenerPorId(int id)
        {
            return dInvitado.ObtenerPorId(id);
        }

        public List<Invitados> BuscarPorDNI(string dni)
        {
            return dInvitado.BuscarPorDNI(dni);
        }

        public List<Invitados> BuscarPorSocio(int idSocio)
        {
            return dInvitado.BuscarPorSocio(idSocio);
        }

        public List<Invitados> BuscarPorFecha(DateTime fecha)
        {
            return dInvitado.BuscarPorFecha(fecha);
        }
    }
}