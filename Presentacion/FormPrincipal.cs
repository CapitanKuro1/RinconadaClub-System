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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(Form frm)
        {
            this.Hide();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormSocios());
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPagos());
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormReservas());
        }

        private void btnInvitados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormInvitados());
        }

        private void btnCarnets_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormCarnet());
        }

        private void btnInstalaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormInstalaciones());
        }

        private void btnAuditorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormAuditoria());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
