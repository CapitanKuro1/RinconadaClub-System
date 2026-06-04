using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NSocio
    {
        private DSocio dSocio = new DSocio();
        private NAuditoria nAuditoria = new NAuditoria();

        public string Registrar(Socio socio)
        {
            string resultado = dSocio.Registrar(socio);

            nAuditoria.Registrar(new Auditoria
            {
                id_usuario = 1, 
                accion = "Registró socio: " + socio.nombre_completo,
                fecha_accion = DateTime.Now
            });

            return resultado;
        }

        public string Modificar(Socio socio)
        {
            string resultado = dSocio.Modificar(socio);

            nAuditoria.Registrar(new Auditoria
            {
                id_usuario = 1,
                accion = "Modificó socio: " + socio.nombre_completo,
                fecha_accion = DateTime.Now
            });

            return resultado;
        }

        public string Eliminar(int id)
        {
            string nombreSocio = dSocio.ObtenerPorId(id)?.nombre_completo ?? "Desconocido";
            string resultado = dSocio.Eliminar(id);

            nAuditoria.Registrar(new Auditoria
            {
                id_usuario = 1,
                accion = "Eliminó socio: " + nombreSocio,
                fecha_accion = DateTime.Now
            });

            return resultado;
        }

        public List<Socio> ListarTodo()
        {
            return dSocio.ListarTodo();
        }

        public Socio ObtenerPorId(int id)
        {
            return dSocio.ObtenerPorId(id);
        }

        public List<Socio> BuscarPorTexto(string texto)
        {
            return dSocio.BuscarPorTexto(texto);
        }
    }
}