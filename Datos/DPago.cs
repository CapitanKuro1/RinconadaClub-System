using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPago
    {
        public String Registrar(Pagos pago)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Pagos.Add(pago);
                    context.SaveChanges();
                }
                return "Pago ha sido registrado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Pagos pago)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Pagos temp = context.Pagos
                                        .Find(pago.id_pago);

                    if (temp == null)
                        return "Pago no encontrado";

                    temp.monto = pago.monto;
                    temp.fecha_pago = pago.fecha_pago;
                    temp.metodo_pago = pago.metodo_pago;
                    temp.id_socio = pago.id_socio;

                    context.SaveChanges();
                }
                return "Pago ha sido modificado";
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
                    Pagos temp = context.Pagos
                                        .Find(id);

                    if (temp == null)
                        return "Pago no encontrado";

                    context.Pagos.Remove(temp);
                    context.SaveChanges();
                }
                return "Pago ha eliminado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Pagos> ListarTodo()
        {
            List<Pagos> lista = new List<Pagos>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Pagos.ToList();
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public Pagos ObtenerPorId(int id)
        {
            Pagos pago = null;

            try
            {
                using (var context = new BDEFEntities())
                {
                    pago = context.Pagos
                                  .Find(id);
                }
                return pago;
            }
            catch
            {
                return pago;
            }
        }

        public List<Pagos> BuscarPorSocio(int id_socio)
        {
            List<Pagos> lista = new List<Pagos>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Pagos
                                   .Where(p => p.id_socio == id_socio)
                                   .ToList();
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public List<Pagos> BuscarPorMes(int mes, int año)
        {
            List<Pagos> lista = new List<Pagos>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    lista = context.Pagos
                                   .Where(p =>
                                        p.fecha_pago.Value.Month == mes &&
                                        p.fecha_pago.Value.Year == año)
                                   .ToList();
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }

        public decimal TotalPagos()
        {
            decimal total = 0;
            try
            {
                using (var context = new BDEFEntities())
                {
                    total = context.Pagos.Sum(p => p.monto ?? 0);
                }
                return total;
            }
            catch
            {
                return total;
            }
        }

        public decimal PromedioPagos()
        {
            decimal promedio = 0;
            try
            {
                using (var context = new BDEFEntities())
                {
                    promedio = context.Pagos.Average(p => p.monto ?? 0);
                }
                return promedio;
            }
            catch
            {
                return promedio;
            }
        }
    }
}
