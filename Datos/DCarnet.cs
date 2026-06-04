using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCarnet
    {
        public String Registrar(Carnet carnet)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Carnet.Add(carnet);
                    context.SaveChanges();
                }
                return "Carnet ha sido registrado ";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Carnet carnet)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Carnet temp = context.Carnet.Find(carnet.id_carnet);

                    if (temp == null)
                        return "Carnet no encontrado";

                    temp.fecha_emision = carnet.fecha_emision;
                    temp.estado = carnet.estado;
                    temp.id_socio = carnet.id_socio;

                    context.SaveChanges();
                }

                return "Carnet ha sido modificado";
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
                    Carnet temp = context.Carnet.Find(id);

                    if (temp == null)
                        return "Carnet no encontrado";

                    context.Carnet.Remove(temp);
                    context.SaveChanges();
                }

                return "Carnet ha sido eliminado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Carnet> ListarTodo()
        {
            List<Carnet> lista = new List<Carnet>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Carnet.ToList();
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public Carnet ObtenerPorId(int id)
        {
            Carnet c = null;

            try
            {
                using (var context = new BDEFEntities())
                {
                    c = context.Carnet.Find(id);
                }
                return c;
            }
            catch
            {
                return c;
            }
        }

        public List<Carnet> BuscarPorSocio(int id_socio)
        {
            List<Carnet> lista = new List<Carnet>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Carnet
                                   .Where(c => c.id_socio == id_socio)
                                   .ToList();
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public List<Carnet> BuscarPorEstado(bool estado)
        {
            List<Carnet> lista = new List<Carnet>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Carnet
                                   .Where(c => c.estado == estado)
                                   .ToList();
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public List<Carnet> BuscarPorAnio(int anio)
        {
            List<Carnet> lista = new List<Carnet>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Carnet
                                   .Where(c => c.fecha_emision.HasValue &&
                                               c.fecha_emision.Value.Year == anio)
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