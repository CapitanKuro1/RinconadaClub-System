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
    public partial class FormInstalaciones : Form
    {
        private NInstalacion nInstalacion = new NInstalacion();

        public FormInstalaciones()
        {
            InitializeComponent();

            CargarCombos();
            MostrarInstalaciones(nInstalacion.ListarTodo());
        }

        private void CargarCombos()
        {
            cbNombre.Items.Clear();
            cbNombre.DropDownStyle = ComboBoxStyle.DropDown;
            cbNombre.Items.AddRange(new string[]
            {
                "Cancha de Fútbol",
                "Cancha de Tenis",
                "Piscina Olímpica",
                "Salón de Eventos",
                "Gimnasio Principal",
                "Restaurante",
                "Auditorio",
                "Zona de Parrillas",
                "Sala de Conferencias",
                "Jardín Exterior"
            });

            cbTipo.Items.Clear();
            cbTipo.DropDownStyle = ComboBoxStyle.DropDown;
            cbTipo.Items.AddRange(new string[]
            {
                "Deporte", "Recreación", "Evento", "Cultural", "Otros"
            });

            cbUbicacion.Items.Clear();
            cbUbicacion.DropDownStyle = ComboBoxStyle.DropDown;
            cbUbicacion.Items.AddRange(new string[]
            {
                "Zona Norte", "Zona Sur", "Zona Este",
                "Zona Oeste", "Edificio A", "Edificio B",
                "Exterior", "Interior"
            });

            cbCapacidad.Items.Clear();
            cbCapacidad.DropDownStyle = ComboBoxStyle.DropDown;
            cbCapacidad.Items.AddRange(new string[]
            {
                "10", "20", "30", "50", "100", "150", "200", "300"
            });
        }

        private void MostrarInstalaciones<T>(List<T> instalaciones)
        {
            dgvInstalaciones.DataSource = null;

            if (instalaciones.Count != 0)
            {
                dgvInstalaciones.DataSource = instalaciones;

                if (dgvInstalaciones.Columns.Contains("Reservas"))
                    dgvInstalaciones.Columns["Reservas"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbNombre.Text == "" || cbTipo.Text == "" || cbUbicacion.Text == "" || cbCapacidad.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos obligatorios.");
                return;
            }

            int capacidad;
            if (!int.TryParse(cbCapacidad.Text, out capacidad))
            {
                MessageBox.Show("La capacidad debe ser un número válido.");
                return;
            }

            Instalaciones inst = new Instalaciones()
            {
                nombre = cbNombre.Text,
                tipo = cbTipo.Text,
                ubicacion = cbUbicacion.Text,
                capacidad = capacidad
            };

            MessageBox.Show(nInstalacion.Registrar(inst));
            MostrarInstalaciones(nInstalacion.ListarTodo());
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvInstalaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una instalación.");
                return;
            }

            if (cbNombre.Text == "" || cbTipo.Text == "" || cbUbicacion.Text == "" || cbCapacidad.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos.");
                return;
            }

            int capacidad;
            if (!int.TryParse(cbCapacidad.Text, out capacidad))
            {
                MessageBox.Show("La capacidad debe ser un número válido.");
                return;
            }

            int id = int.Parse(dgvInstalaciones.SelectedRows[0].Cells["id_instalacion"].Value.ToString());

            Instalaciones inst = new Instalaciones()
            {
                id_instalacion = id,
                nombre = cbNombre.Text,
                tipo = cbTipo.Text,
                ubicacion = cbUbicacion.Text,
                capacidad = capacidad
            };

            MessageBox.Show(nInstalacion.Modificar(inst));
            MostrarInstalaciones(nInstalacion.ListarTodo());
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInstalaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una instalación.");
                return;
            }

            int id = int.Parse(dgvInstalaciones.SelectedRows[0].Cells["id_instalacion"].Value.ToString());

            MessageBox.Show(nInstalacion.Eliminar(id));
            MostrarInstalaciones(nInstalacion.ListarTodo());
            LimpiarCampos();
        }

        private void dgvInstalaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvInstalaciones.SelectedRows.Count == 0) return;

                txtIdInstalacion.Text = dgvInstalaciones.SelectedRows[0].Cells["id_instalacion"].Value.ToString();
                cbNombre.Text = dgvInstalaciones.SelectedRows[0].Cells["nombre"].Value.ToString();
                cbTipo.Text = dgvInstalaciones.SelectedRows[0].Cells["tipo"].Value.ToString();
                cbUbicacion.Text = dgvInstalaciones.SelectedRows[0].Cells["ubicacion"].Value.ToString();
                cbCapacidad.Text = dgvInstalaciones.SelectedRows[0].Cells["capacidad"].Value.ToString();
            }
            catch { }
        }

        private void LimpiarCampos()
        {
            txtIdInstalacion.Text = "";
            cbNombre.SelectedIndex = -1;
            cbTipo.SelectedIndex = -1;
            cbUbicacion.SelectedIndex = -1;
            cbCapacidad.SelectedIndex = -1;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
