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
    public partial class FormPagos : Form
    {
        private NPago nPago = new NPago();
        private NSocio nSocio = new NSocio();

        public FormPagos()
        {
            InitializeComponent();
            MostrarSocios(nSocio.ListarTodo());
            MostrarPagos(nPago.ListarTodo());
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

        private void MostrarPagos<T>(List<T> pagos)
        {
            dgvPagos.DataSource = null;

            if (pagos.Count != 0)
            {
                dgvPagos.DataSource = pagos;

                if (dgvPagos.Columns.Contains("Socio"))
                    dgvPagos.Columns["Socio"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbSocio.Text == "" || txtMonto.Text == "" || cbMetodoPago.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            decimal monto;
            try
            {
                monto = decimal.Parse(txtMonto.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese un monto válido");
                return;
            }

            Pagos p = new Pagos()
            {
                monto = monto,
                fecha_pago = dtFechaPago.Value,
                metodo_pago = cbMetodoPago.Text,
                id_socio = int.Parse(cbSocio.SelectedValue.ToString())
            };

            string mensaje = nPago.Registrar(p);
            MessageBox.Show(mensaje);

            MostrarPagos(nPago.ListarTodo());
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPagos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un pago");
                return;
            }

            if (txtMonto.Text == "" || cbMetodoPago.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            decimal monto;
            try
            {
                monto = decimal.Parse(txtMonto.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese un monto válido");
                return;
            }

            int pagoId = int.Parse(
                dgvPagos.SelectedRows[0].Cells["id_pago"].Value.ToString()
            );

            Pagos p = new Pagos()
            {
                id_pago = pagoId,
                monto = monto,
                fecha_pago = dtFechaPago.Value,
                metodo_pago = cbMetodoPago.Text,
                id_socio = int.Parse(cbSocio.SelectedValue.ToString())
            };

            string mensaje = nPago.Modificar(p);
            MessageBox.Show(mensaje);

            MostrarPagos(nPago.ListarTodo());
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPagos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un pago");
                return;
            }

            int pagoId = int.Parse(
                dgvPagos.SelectedRows[0].Cells["id_pago"].Value.ToString()
            );

            string mensaje = nPago.Eliminar(pagoId);
            MessageBox.Show(mensaje);

            MostrarPagos(nPago.ListarTodo());
            LimpiarCampos();
        }

        private void dgvPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPagos.SelectedRows.Count == 0) return;

                txtIdPago.Text = dgvPagos.SelectedRows[0].Cells["id_pago"].Value.ToString();
                txtMonto.Text = dgvPagos.SelectedRows[0].Cells["monto"].Value.ToString();
                dtFechaPago.Value = Convert.ToDateTime(
                    dgvPagos.SelectedRows[0].Cells["fecha_pago"].Value
                );
                cbMetodoPago.Text = dgvPagos.SelectedRows[0].Cells["metodo_pago"].Value.ToString();
                cbSocio.SelectedValue = dgvPagos.SelectedRows[0].Cells["id_socio"].Value;
            }
            catch { }
        }

        private void LimpiarCampos()
        {
            txtIdPago.Text = "";
            txtMonto.Text = "";
            cbMetodoPago.SelectedIndex = -1;
            cbSocio.SelectedIndex = -1;

            dtFechaPago.Value = DateTime.Now;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}