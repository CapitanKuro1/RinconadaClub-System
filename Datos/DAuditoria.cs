using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAuditoria
    {
        public string Registrar(Auditoria auditoria)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Auditoria.Add(auditoria);
                    context.SaveChanges();
                }
                return "Auditoria ha sido registrada";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Auditoria> ListarTodo()
        {
            List<Auditoria> lista = new List<Auditoria>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Auditoria.ToList();
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public List<Auditoria> BuscarPorUsuario(string usuarioTexto)
        {
            List<Auditoria> lista = new List<Auditoria>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Auditoria
                                   .Where(a => a.id_usuario.ToString().Contains(usuarioTexto))
                                   .ToList();
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public List<Auditoria> BuscarPorAccion(string accion)
        {
            List<Auditoria> lista = new List<Auditoria>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Auditoria
                                   .Where(a => a.accion.Contains(accion))
                                   .ToList();
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public List<Auditoria> BuscarPorFecha(DateTime fecha)
        {
            List<Auditoria> lista = new List<Auditoria>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Auditoria
                                   .Where(a => a.fecha_accion.HasValue &&
                                               a.fecha_accion.Value.Date == fecha.Date)
                                   .ToList();
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public List<Auditoria> BuscarPorRangoFechas(DateTime inicio, DateTime fin)
        {
            List<Auditoria> lista = new List<Auditoria>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Auditoria
                                   .Where(a => a.fecha_accion.HasValue &&
                                               a.fecha_accion.Value >= inicio &&
                                               a.fecha_accion.Value <= fin)
                                   .ToList();
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }
        public List<dynamic> AgruparPorUsuario()
        {
            using (var context = new BDEFEntities())
            {
                var query = context.Auditoria
                    .GroupBy(a => a.id_usuario)
                    .Select(g => new
                    {
                        Usuario = g.Key,
                        Cantidad = g.Count()
                    }).ToList();

                return query.Cast<dynamic>().ToList();
            }
        }

        public List<dynamic> AgruparPorDia()
        {
            using (var context = new BDEFEntities())
            {
                var lista = context.Auditoria
                    .Where(a => a.fecha_accion.HasValue)
                    .ToList();  

                var query = lista
                    .GroupBy(a => a.fecha_accion.Value.Date)
                    .Select(g => new
                    {
                        Fecha = g.Key,
                        Cantidad = g.Count()
                    })
                    .ToList();

                return query.Cast<dynamic>().ToList();
            }
        }
        public List<dynamic> AgruparPorAccion()
        {
            using (var context = new BDEFEntities())
            {
                var total = context.Auditoria.Count();
                var query = context.Auditoria
                    .GroupBy(a => a.accion)
                    .Select(g => new { Accion = g.Key, Cantidad = g.Count() })
                    .ToList();

                return query.Cast<dynamic>().ToList();
            }
        }
    }
}