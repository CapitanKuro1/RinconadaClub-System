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
    public partial class FormInvitados : Form
    {
        private NInvitado nInvitado = new NInvitado();
        private NSocio nSocio = new NSocio();

        public FormInvitados()
        {
            InitializeComponent();
            MostrarSocios(nSocio.ListarTodo());
            MostrarInvitados(nInvitado.ListarTodo());
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

        private void MostrarInvitados<T>(List<T> invitados)
        {
            dgvInvitados.DataSource = null;

            if (invitados.Count != 0)
            {
                dgvInvitados.DataSource = invitados;

                if (dgvInvitados.Columns.Contains("Socio"))
                    dgvInvitados.Columns["Socio"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbSocio.Text == "" || txtNombreInvitado.Text == "" || txtDniInvitado.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Invitados inv = new Invitados()
            {
                nombre_invitado = txtNombreInvitado.Text,
                dni_invitado = txtDniInvitado.Text,
                fecha_visita = dtFechaVisita.Value,
                id_socio = int.Parse(cbSocio.SelectedValue.ToString())
            };

            string mensaje = nInvitado.Registrar(inv);
            MessageBox.Show(mensaje);

            MostrarInvitados(nInvitado.ListarTodo());
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvInvitados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un invitado");
                return;
            }

            if (txtNombreInvitado.Text == "" || txtDniInvitado.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            int invitadoId = int.Parse(
                dgvInvitados.SelectedRows[0].Cells["id_invitado"].Value.ToString()
            );

            Invitados inv = new Invitados()
            {
                id_invitado = invitadoId,
                nombre_invitado = txtNombreInvitado.Text,
                dni_invitado = txtDniInvitado.Text,
                fecha_visita = dtFechaVisita.Value,
                id_socio = int.Parse(cbSocio.SelectedValue.ToString())
            };

            string mensaje = nInvitado.Modificar(inv);
            MessageBox.Show(mensaje);

            MostrarInvitados(nInvitado.ListarTodo());
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInvitados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un invitado");
                return;
            }

            int invitadoId = int.Parse(
                dgvInvitados.SelectedRows[0].Cells["id_invitado"].Value.ToString()
            );

            string mensaje = nInvitado.Eliminar(invitadoId);
            MessageBox.Show(mensaje);

            MostrarInvitados(nInvitado.ListarTodo());
            LimpiarCampos();
        }

        private void dgvInvitados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvInvitados.SelectedRows.Count == 0) return;

                txtIdInvitado.Text = dgvInvitados.SelectedRows[0].Cells["id_invitado"].Value.ToString();
                txtNombreInvitado.Text = dgvInvitados.SelectedRows[0].Cells["nombre_invitado"].Value.ToString();
                txtDniInvitado.Text = dgvInvitados.SelectedRows[0].Cells["dni_invitado"].Value.ToString();
                dtFechaVisita.Value = Convert.ToDateTime(
                    dgvInvitados.SelectedRows[0].Cells["fecha_visita"].Value
                );
                cbSocio.SelectedValue = dgvInvitados.SelectedRows[0].Cells["id_socio"].Value;
            }
            catch { }
        }

        private void LimpiarCampos()
        {
            txtIdInvitado.Text = "";
            txtNombreInvitado.Text = "";
            txtDniInvitado.Text = "";
            cbSocio.SelectedIndex = -1;
            dtFechaVisita.Value = DateTime.Now;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}