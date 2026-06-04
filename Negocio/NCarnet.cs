using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCarnet
    {
        private readonly DCarnet dCarnet = new DCarnet();

        public string Registrar(Carnet c)
        {
            return dCarnet.Registrar(c);
        }

        public string Modificar(Carnet c)
        {
            return dCarnet.Modificar(c);
        }

        public string Eliminar(int id)
        {
            return dCarnet.Eliminar(id);
        }

        public List<Carnet> ListarTodo()
        {
            return dCarnet.ListarTodo();
        }

        public Carnet ObtenerPorId(int id)
        {
            return dCarnet.ObtenerPorId(id);
        }
    }
}