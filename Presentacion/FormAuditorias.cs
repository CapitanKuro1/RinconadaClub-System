using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentacion
{
    public partial class FormAuditoria : Form
    {
        private NAuditoria nAuditoria = new NAuditoria();

        public FormAuditoria()
        {
            InitializeComponent();
            ConfigurarChart();
        }

        private void MostrarEnDatagrid<T>(List<T> lista)
        {
            dgvAuditoria.DataSource = null;
            if (lista.Count > 0)
                dgvAuditoria.DataSource = lista;
        }

        private void ConfigurarChart()
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.ChartAreas.Clear();

            chart1.ChartAreas.Add(new ChartArea("Area1"));
            chart1.Legends.Add("Leyenda");
        }

        private void MostrarGraficoPie(Dictionary<string, decimal> datos, string titulo)
        {
            chart1.Series.Clear();

            Series serie = new Series
            {
                Name = "Datos",
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            foreach (var item in datos)
                serie.Points.AddXY(item.Key, item.Value);

            chart1.Series.Add(serie);
            chart1.Titles.Clear();
            chart1.Titles.Add(titulo);
        }

        private Dictionary<string, decimal> ConvertirADiccionario(List<dynamic> datos)
        {
            Dictionary<string, decimal> pie = new Dictionary<string, decimal>();

            foreach (var item in datos)
            {
                var tipo = item.GetType();

                var propUsuario = tipo.GetProperty("Usuario");
                var propAccion = tipo.GetProperty("Accion");
                var propFecha = tipo.GetProperty("Fecha");
                var propCantidad = tipo.GetProperty("Cantidad");

                string clave = "Sin Datos";

                if (propUsuario != null)
                    clave = propUsuario.GetValue(item)?.ToString() ?? "Sin Usuario";

                else if (propAccion != null)
                    clave = propAccion.GetValue(item)?.ToString() ?? "Sin Acción";

                else if (propFecha != null)
                    clave = Convert.ToDateTime(propFecha.GetValue(item)).ToShortDateString();

                decimal valor = 0;
                if (propCantidad != null)
                    valor = Convert.ToDecimal(propCantidad.GetValue(item));

                if (!pie.ContainsKey(clave))
                    pie.Add(clave, valor);
            }

            return pie;
        }


        private void btnAccionesPorUsuario_Click(object sender, EventArgs e)
        {
            var datos = nAuditoria.AccionesPorUsuario();
            MostrarEnDatagrid(datos);

            var pie = ConvertirADiccionario(datos);
            MostrarGraficoPie(pie, "Acciones por Usuario");
        }

        private void btnAccionesFrecuentes_Click(object sender, EventArgs e)
        {
            var datos = nAuditoria.AccionesFrecuentes();
            MostrarEnDatagrid(datos);

            var pie = ConvertirADiccionario(datos);
            MostrarGraficoPie(pie, "Acciones Frecuentes");
        }

        private void btnAuditoriaPorDia_Click(object sender, EventArgs e)
        {
            var datos = nAuditoria.AuditoriaPorDia();
            MostrarEnDatagrid(datos);

            var pie = ConvertirADiccionario(datos);
            MostrarGraficoPie(pie, "Auditorías por Día");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}