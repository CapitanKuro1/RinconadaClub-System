using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Negocio
{
    public class NAuditoria
    {
        private readonly DAuditoria dAuditoria = new DAuditoria();

        public string Registrar(Auditoria a)
        {
            return dAuditoria.Registrar(a);
        }

        public List<Auditoria> ListarTodo()
        {
            return dAuditoria.ListarTodo();
        }

        public List<Auditoria> BuscarPorUsuario(string usuario)
        {
            return dAuditoria.BuscarPorUsuario(usuario);
        }
        public List<dynamic> AccionesPorUsuario()
        {
            return dAuditoria.AgruparPorUsuario();
        }

        public List<dynamic> AccionesFrecuentes()
        {
            return dAuditoria.AgruparPorAccion();
        }

        public List<dynamic> AuditoriaPorDia()
        {
            return dAuditoria.AgruparPorDia();
        }
    }
}