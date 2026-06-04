using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPago
    {
        private DPago dPago = new DPago();

        public string Registrar(Pagos p)
        {
            return dPago.Registrar(p);
        }

        public string Modificar(Pagos p)
        {
            return dPago.Modificar(p);
        }

        public string Eliminar(int id)
        {
            return dPago.Eliminar(id);
        }

        public List<Pagos> ListarTodo()
        {
            return dPago.ListarTodo();
        }

        public Pagos ObtenerPorId(int id)
        {
            return dPago.ObtenerPorId(id);
        }
    }
}