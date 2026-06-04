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
    public partial class FormSocios : Form
    {
        private NSocio nSocio = new NSocio();

        public FormSocios()
        {
            InitializeComponent();
            MostrarSocios(nSocio.ListarTodo());
        }

        private void MostrarSocios<T>(List<T> socios)
        {
            dgvSocios.DataSource = null;

            if (socios.Count != 0)
            {
                dgvSocios.DataSource = socios;

                if (dgvSocios.Columns.Contains("Carnet"))
                    dgvSocios.Columns["Carnet"].Visible = false;

                if (dgvSocios.Columns.Contains("Invitados"))
                    dgvSocios.Columns["Invitados"].Visible = false;

                if (dgvSocios.Columns.Contains("Pagos"))
                    dgvSocios.Columns["Pagos"].Visible = false;

                if (dgvSocios.Columns.Contains("Reservas"))
                    dgvSocios.Columns["Reservas"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDni.Text == "" ||
                txtCorreo.Text == "" || txtTelefono.Text == "" ||
                txtDireccion.Text == "" || cbEstado.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Socio socio = new Socio()
            {
                nombre_completo = txtNombre.Text,
                dni = txtDni.Text,
                correo = txtCorreo.Text,
                telefono = txtTelefono.Text,
                direccion = txtDireccion.Text,
                estado = (cbEstado.Text == "Activo")
            };

            string mensaje = nSocio.Registrar(socio);
            MessageBox.Show(mensaje);

            MostrarSocios(nSocio.ListarTodo());
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIdSocio.Text == "")
            {
                MessageBox.Show("Seleccione un socio");
                return;
            }

            if (txtNombre.Text == "" || txtDni.Text == "" ||
                txtCorreo.Text == "" || txtTelefono.Text == "" ||
                txtDireccion.Text == "" || cbEstado.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Socio socio = new Socio()
            {
                id_socio = int.Parse(txtIdSocio.Text),
                nombre_completo = txtNombre.Text,
                dni = txtDni.Text,
                correo = txtCorreo.Text,
                telefono = txtTelefono.Text,
                direccion = txtDireccion.Text,
                estado = (cbEstado.Text == "Activo")
            };

            string mensaje = nSocio.Modificar(socio);
            MessageBox.Show(mensaje);

            MostrarSocios(nSocio.ListarTodo());
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSocios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un socio");
                return;
            }

            int socioId = int.Parse(
                dgvSocios.SelectedRows[0].Cells["id_socio"].Value.ToString()
            );

            string mensaje = nSocio.Eliminar(socioId);
            MessageBox.Show(mensaje);

            MostrarSocios(nSocio.ListarTodo());
            LimpiarCampos();
        }

        private void dgvSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSocios.SelectedRows.Count == 0) return;

                txtIdSocio.Text = dgvSocios.SelectedRows[0].Cells["id_socio"].Value.ToString();
                txtNombre.Text = dgvSocios.SelectedRows[0].Cells["nombre_completo"].Value.ToString();
                txtDni.Text = dgvSocios.SelectedRows[0].Cells["dni"].Value.ToString();
                txtCorreo.Text = dgvSocios.SelectedRows[0].Cells["correo"].Value.ToString();
                txtTelefono.Text = dgvSocios.SelectedRows[0].Cells["telefono"].Value.ToString();
                txtDireccion.Text = dgvSocios.SelectedRows[0].Cells["direccion"].Value.ToString();

                bool estado = (bool)dgvSocios.SelectedRows[0].Cells["estado"].Value;
                cbEstado.Text = estado ? "Activo" : "Inactivo";
            }
            catch { }
        }

        private void LimpiarCampos()
        {
            txtIdSocio.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            cbEstado.SelectedIndex = -1;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
