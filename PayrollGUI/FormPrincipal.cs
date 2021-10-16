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
        public void seleccionarBoton(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            btnInicio.Textcolor = Color.White;
            btnNomina.Textcolor = Color.White;
            btnPersonas.Textcolor = Color.White;
            btnReportes.Textcolor = Color.White;
            btnEmpresa.Textcolor = Color.White;
            btnAjustes.Textcolor = Color.White;
            sender.selected = true;
            if (sender.selected)
            {
                sender.Activecolor = Color.Indigo;
            }
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {

        }

        private void pnlVista_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            abrirFormulario(new FormInicio());
            seleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton) sender);
        }

        private void btnNomina_Click_1(object sender, EventArgs e)
        {
            abrirFormulario(new FormNomina());
            seleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnPersonas_Click_1(object sender, EventArgs e)
        {
            abrirFormulario(new FormPersonas());
            seleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void pictureBoxSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormReportes());
            seleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormEmpresa());
            seleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormAjustes());
            seleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }
    }
}
