using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormInicio());
        }

        private void abrirFormulario(object panelControl)
        {
            if (this.pnlVista.Controls.Count > 0)
                this.pnlVista.Controls.RemoveAt(0);
            Form formulario = panelControl as Form;
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            this.pnlVista.Controls.Add(formulario);
            this.pnlVista.Tag = formulario;
            formulario.Show();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormPersonas());
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {

        }

        private void btnNomina_Click(object sender, EventArgs e)
        {

        }

        private void pnlVista_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
