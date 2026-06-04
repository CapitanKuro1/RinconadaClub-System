using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NInstalacion
    {
        private readonly DInstalacion dInst = new DInstalacion();

        public string Registrar(Instalaciones i)
        {
            return dInst.Registrar(i);
        }

        public string Modificar(Instalaciones i)
        {
            return dInst.Modificar(i);
        }

        public string Eliminar(int id)
        {
            return dInst.Eliminar(id);
        }

        public List<Instalaciones> ListarTodo()
        {
            return dInst.ListarTodo();
        }

        public Instalaciones ObtenerPorId(int id)
        {
            return dInst.ObtenerPorId(id);
        }

        public List<Instalaciones> BuscarPorNombre(string nombre)
        {
            return dInst.BuscarPorNombre(nombre);
        }

        public List<Instalaciones> BuscarPorTipo(string tipo)
        {
            return dInst.BuscarPorTipo(tipo);
        }

        public List<Instalaciones> BuscarPorUbicacion(string ubicacion)
        {
            return dInst.BuscarPorUbicacion(ubicacion);
        }
    }
}