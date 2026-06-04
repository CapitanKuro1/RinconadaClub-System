using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DSocio
    {
        public String Registrar(Socio socio)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Socio.Add(socio);
                    context.SaveChanges();
                }
                return "Socio ha sido registrado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Socio socio)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Socio temp = context.Socio.Find(socio.id_socio);
                    if (temp == null) return "Socio no encontrado";

                    temp.nombre_completo = socio.nombre_completo;
                    temp.dni = socio.dni;
                    temp.correo = socio.correo;
                    temp.telefono = socio.telefono;
                    temp.direccion = socio.direccion;
                    temp.estado = socio.estado;

                    context.SaveChanges();
                }
                return "Modificado exitosamente";
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
                    Socio temp = context.Socio.Find(id);
                    if (temp == null) return "Socio no encontrado";

                    context.Socio.Remove(temp);
                    context.SaveChanges();
                }
                return "Eliminado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Socio> ListarTodo()
        {
            List<Socio> lista = new List<Socio>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Socio.ToList();
                }
                return lista;
            }
            catch (Exception ex)
            {
                return lista;
            }
        }

        public Socio ObtenerPorId(int id)
        {
            Socio socio = null;

            try
            {
                using (var context = new BDEFEntities())
                {
                    socio = context.Socio
                                   .Find(id);
                }
                return socio;
            }
            catch
            {
                return socio;
            }
        }

        public List<Socio> BuscarPorTexto(string texto)
        {
            List<Socio> lista = new List<Socio>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Socio
                        .Where(s =>
                            s.nombre_completo.Contains(texto) ||
                            s.dni.Contains(texto))
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