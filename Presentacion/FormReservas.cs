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

namespace Presentacion
{
    public partial class FormReservas : Form
    {
        private NReserva nReserva = new NReserva();
        private NSocio nSocio = new NSocio();
        private NInstalacion nInstalacion = new NInstalacion();

        public FormReservas()
        {
            InitializeComponent();
            MostrarSocios(nSocio.ListarTodo());
            MostrarInstalaciones(nInstalacion.ListarTodo());
            CargarAreas();
            MostrarReservas(nReserva.ListarTodo());
        }

        private void MostrarSocios<T>(List<T> socios)
        {
            cbSocio.DataSource = null;

            if (socios.Count != 0)
            {
                cbSocio.DataSource = socios;
                cbSocio.DisplayMember = "nombre_completo";
                cbSocio.ValueMember = "id_socio";
            }
        }

        private void MostrarInstalaciones<T>(List<T> instalaciones)
        {
            cbInstalacion.DataSource = null;

            if (instalaciones.Count != 0)
            {
                cbInstalacion.DataSource = instalaciones;
                cbInstalacion.DisplayMember = "nombre";
                cbInstalacion.ValueMember = "id_instalacion";
            }
        }

        private void CargarAreas()
        {
            cbArea.Items.Clear();

            cbArea.Items.AddRange(new string[]
            {
                "Zona A",
                "Zona B",
                "Zona Infantil",
                "Piscina",
                "Cancha 1",
                "Cancha 2",
                "Auditorio",
                "Libre"
            });
        }

        private void MostrarReservas<T>(List<T> reservas)
        {
            dgvReservas.DataSource = null;

            if (reservas.Count != 0)
            {
                dgvReservas.DataSource = reservas;

                if (dgvReservas.Columns.Contains("Socio"))
                    dgvReservas.Columns["Socio"].Visible = false;

                if (dgvReservas.Columns.Contains("Instalaciones"))
                    dgvReservas.Columns["Instalaciones"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbSocio.Text == "" || cbInstalacion.Text == "" || cbArea.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos.");
                return;
            }

            Reservas r = new Reservas()
            {
                fecha_reserva = dtFecha.Value,
                hora_inicio = dtHoraInicio.Value.TimeOfDay,
                hora_fin = dtHoraFin.Value.TimeOfDay,
                area = cbArea.Text,
                id_socio = int.Parse(cbSocio.SelectedValue.ToString()),
                id_instalacion = int.Parse(cbInstalacion.SelectedValue.ToString())
            };

            string mensaje = nReserva.Registrar(r);
            MessageBox.Show(mensaje);

            MostrarReservas(nReserva.ListarTodo());
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIdReserva.Text == "")
            {
                MessageBox.Show("Seleccione una reserva.");
                return;
            }

            if (cbSocio.Text == "" || cbInstalacion.Text == "" || cbArea.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos.");
                return;
            }

            Reservas r = new Reservas()
            {
                id_reserva = int.Parse(txtIdReserva.Text),
                fecha_reserva = dtFecha.Value,
                hora_inicio = dtHoraInicio.Value.TimeOfDay,
                hora_fin = dtHoraFin.Value.TimeOfDay,
                area = cbArea.Text,
                id_socio = int.Parse(cbSocio.SelectedValue.ToString()),
                id_instalacion = int.Parse(cbInstalacion.SelectedValue.ToString())
            };

            string mensaje = nReserva.Modificar(r);
            MessageBox.Show(mensaje);

            MostrarReservas(nReserva.ListarTodo());
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva.");
                return;
            }

            int reservaId = int.Parse(
                dgvReservas.SelectedRows[0].Cells["id_reserva"].Value.ToString()
            );

            string mensaje = nReserva.Eliminar(reservaId);
            MessageBox.Show(mensaje);

            MostrarReservas(nReserva.ListarTodo());
            LimpiarCampos();
        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvReservas.SelectedRows.Count == 0) return;

                txtIdReserva.Text = dgvReservas.SelectedRows[0].Cells["id_reserva"].Value.ToString();

                dtFecha.Value = Convert.ToDateTime(
                    dgvReservas.SelectedRows[0].Cells["fecha_reserva"].Value
                );

                dtHoraInicio.Value = DateTime.Today +
                    (TimeSpan)dgvReservas.SelectedRows[0].Cells["hora_inicio"].Value;

                dtHoraFin.Value = DateTime.Today +
                    (TimeSpan)dgvReservas.SelectedRows[0].Cells["hora_fin"].Value;

                cbArea.Text = dgvReservas.SelectedRows[0].Cells["area"].Value.ToString();
                cbSocio.SelectedValue = dgvReservas.SelectedRows[0].Cells["id_socio"].Value;
                cbInstalacion.SelectedValue = dgvReservas.SelectedRows[0].Cells["id_instalacion"].Value;
            }
            catch { }
        }

        private void LimpiarCampos()
        {
            txtIdReserva.Text = "";
            cbArea.SelectedIndex = -1;
            cbSocio.SelectedIndex = -1;
            cbInstalacion.SelectedIndex = -1;

            dtFecha.Value = DateTime.Now;
            dtHoraInicio.Value = DateTime.Now;
            dtHoraFin.Value = DateTime.Now;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}