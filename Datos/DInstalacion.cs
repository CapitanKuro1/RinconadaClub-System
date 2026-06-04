using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DInstalacion
    {
        public String Registrar(Instalaciones instalacion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Instalaciones.Add(instalacion);
                    context.SaveChanges();
                }
                return "Instalación ha sido registrada";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Instalaciones instalacion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Instalaciones temp = context.Instalaciones
                                                .Find(instalacion.id_instalacion);

                    if (temp == null)
                        return "Instalación no encontrada";

                    temp.nombre = instalacion.nombre;
                    temp.tipo = instalacion.tipo;
                    temp.ubicacion = instalacion.ubicacion;
                    temp.capacidad = instalacion.capacidad;

                    context.SaveChanges();
                }

                return "Instalación ha sido modificada";
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
                    Instalaciones temp = context.Instalaciones
                                                .Find(id);

                    if (temp == null)
                        return "Instalación no encontrada";

                    context.Instalaciones.Remove(temp);
                    context.SaveChanges();
                }
                return "Instalación ha sido eliminada ";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Instalaciones> ListarTodo()
        {
            List<Instalaciones> lista = new List<Instalaciones>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Instalaciones.ToList();
                }

                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public Instalaciones ObtenerPorId(int id)
        {
            Instalaciones instalacion = null;

            try
            {
                using (var context = new BDEFEntities())
                {
                    instalacion = context.Instalaciones
                                         .Find(id);
                }
                return instalacion;
            }
            catch
            {
                return instalacion;
            }
        }

        public List<Instalaciones> BuscarPorNombre(string texto)
        {
            List<Instalaciones> lista = new List<Instalaciones>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Instalaciones
                                   .Where(i => i.nombre.Contains(texto))
                                   .ToList();
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public List<Instalaciones> BuscarPorTipo(string tipo)
        {
            List<Instalaciones> lista = new List<Instalaciones>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Instalaciones
                                   .Where(i => i.tipo.Contains(tipo))
                                   .ToList();
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public List<Instalaciones> BuscarPorUbicacion(string ubicacion)
        {
            List<Instalaciones> lista = new List<Instalaciones>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Instalaciones
                                   .Where(i => i.ubicacion.Contains(ubicacion))
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
