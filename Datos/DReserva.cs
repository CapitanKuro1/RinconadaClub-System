using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DReserva
    {
        public String Registrar(Reservas reserva)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Reservas.Add(reserva);
                    context.SaveChanges();
                }
                return "Reserva ha sido registrada";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Reservas reserva)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Reservas temp = context.Reservas
                                            .Find(reserva.id_reserva);

                    if (temp == null)
                        return "Reserva no encontrada";

                    temp.fecha_reserva = reserva.fecha_reserva;
                    temp.hora_inicio = reserva.hora_inicio;
                    temp.hora_fin = reserva.hora_fin;
                    temp.id_socio = reserva.id_socio;
                    temp.area = reserva.area;
                    temp.id_instalacion = reserva.id_instalacion;

                    context.SaveChanges();
                }

                return "Reserva ha sido modificada";
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
                    Reservas temp = context.Reservas
                                            .Find(id);

                    if (temp == null)
                        return "Reserva no encontrada.";

                    context.Reservas.Remove(temp);
                    context.SaveChanges();
                }

                return "Reserva ha sido eliminada";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Reservas> ListarTodo()
        {
            List<Reservas> lista = new List<Reservas>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Reservas.ToList();
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public Reservas ObtenerPorId(int id)
        {
            Reservas reserva = null;

            try
            {
                using (var context = new BDEFEntities())
                {
                    reserva = context.Reservas
                                     .Find(id);
                }
                return reserva;
            }
            catch
            {
                return reserva;
            }
        }

        public List<Reservas> BuscarPorSocio(int id_socio)
        {
            List<Reservas> lista = new List<Reservas>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Reservas
                                   .Where(r => r.id_socio == id_socio)
                                   .ToList();
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public List<Reservas> BuscarPorFecha(DateTime fecha)
        {
            List<Reservas> lista = new List<Reservas>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Reservas
                                   .Where(r => r.fecha_reserva.Value.Date == fecha.Date)
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