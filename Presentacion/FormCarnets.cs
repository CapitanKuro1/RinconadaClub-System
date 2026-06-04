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
    public partial class FormCarnet : Form
    {
        private NCarnet nCarnet = new NCarnet();
        private NSocio nSocio = new NSocio();

        public FormCarnet()
        {
            InitializeComponent();
            MostrarSocios(nSocio.ListarTodo());
            MostrarCarnets(nCarnet.ListarTodo());
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

        private void MostrarCarnets<T>(List<T> carnets)
        {
            dgvCarnets.DataSource = null;

            if (carnets.Count != 0)
            {
                dgvCarnets.DataSource = carnets;

                if (dgvCarnets.Columns.Contains("Socio"))
                    dgvCarnets.Columns["Socio"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbSocio.Text == "" || cbEstado.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Carnet c = new Carnet()
            {
                fecha_emision = dtFechaEmision.Value,
                estado = cbEstado.Text == "Activo",
                id_socio = int.Parse(cbSocio.SelectedValue.ToString())
            };

            string mensaje = nCarnet.Registrar(c);
            MessageBox.Show(mensaje);

            MostrarCarnets(nCarnet.ListarTodo());
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCarnets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un carnet");
                return;
            }

            if (cbSocio.Text == "" || cbEstado.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            int id = int.Parse(
                dgvCarnets.SelectedRows[0].Cells["id_carnet"].Value.ToString()
            );

            Carnet c = new Carnet()
            {
                id_carnet = id,
                fecha_emision = dtFechaEmision.Value,
                estado = cbEstado.Text == "Activo",
                id_socio = int.Parse(cbSocio.SelectedValue.ToString())
            };

            string mensaje = nCarnet.Modificar(c);
            MessageBox.Show(mensaje);

            MostrarCarnets(nCarnet.ListarTodo());
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCarnets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un carnet");
                return;
            }

            int id = int.Parse(
                dgvCarnets.SelectedRows[0].Cells["id_carnet"].Value.ToString()
            );

            string mensaje = nCarnet.Eliminar(id);
            MessageBox.Show(mensaje);

            MostrarCarnets(nCarnet.ListarTodo());
            LimpiarCampos();
        }

        private void dgvCarnets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCarnets.SelectedRows.Count == 0) return;

                txtIdCarnet.Text = dgvCarnets.SelectedRows[0].Cells["id_carnet"].Value.ToString();
                dtFechaEmision.Value = Convert.ToDateTime(
                    dgvCarnets.SelectedRows[0].Cells["fecha_emision"].Value
                );

                bool estado = Convert.ToBoolean(
                    dgvCarnets.SelectedRows[0].Cells["estado"].Value
                );

                cbEstado.Text = estado ? "Activo" : "Inactivo";

                cbSocio.SelectedValue = dgvCarnets.SelectedRows[0].Cells["id_socio"].Value;
            }
            catch { }
        }

        private void LimpiarCampos()
        {
            txtIdCarnet.Text = "";
            dtFechaEmision.Value = DateTime.Now;
            cbEstado.SelectedIndex = -1;
            cbSocio.SelectedIndex = -1;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}