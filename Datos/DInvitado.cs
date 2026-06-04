using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DInvitado
    {
        public String Registrar(Invitados invitado)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Invitados.Add(invitado);
                    context.SaveChanges();
                }

                return "Invitado registrado exitosamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Invitados invitado)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Invitados temp = context.Invitados
                                            .Find(invitado.id_invitado);

                    if (temp == null)
                        return "Invitado no encontrado.";

                    temp.nombre_invitado = invitado.nombre_invitado;
                    temp.dni_invitado = invitado.dni_invitado;
                    temp.id_socio = invitado.id_socio;
                    temp.fecha_visita = invitado.fecha_visita;

                    context.SaveChanges();
                }

                return "Invitado modificado exitosamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int id)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Invitados temp = context.Invitados
                                            .Find(id);

                    if (temp == null)
                        return "Invitado no encontrado.";

                    context.Invitados.Remove(temp);
                    context.SaveChanges();
                }

                return "Invitado eliminado exitosamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Invitados> ListarTodo()
        {
            List<Invitados> lista = new List<Invitados>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Invitados.ToList();
                }

                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public Invitados ObtenerPorId(int id)
        {
            Invitados invitado = null;

            try
            {
                using (var context = new BDEFEntities())
                {
                    invitado = context.Invitados
                                      .Find(id);
                }
                return invitado;
            }
            catch
            {
                return invitado;
            }
        }

        public List<Invitados> BuscarPorDNI(string dni)
        {
            List<Invitados> lista = new List<Invitados>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Invitados
                                   .Where(i => i.dni_invitado.Contains(dni))
                                   .ToList();
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public List<Invitados> BuscarPorSocio(int id_socio)
        {
            List<Invitados> lista = new List<Invitados>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Invitados
                                   .Where(i => i.id_socio == id_socio)
                                   .ToList();
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public List<Invitados> BuscarPorFecha(DateTime fecha)
        {
            List<Invitados> lista = new List<Invitados>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Invitados
                                   .Where(i => i.fecha_visita == fecha)
                                   .ToList();
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }
    }
}
