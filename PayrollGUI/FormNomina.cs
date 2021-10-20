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
    public partial class FormNomina : Form
    {
        public FormNomina()
        {
            InitializeComponent();
           
        }
       
        private void pnlPersonas_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnLiquidar_Click_1(object sender, EventArgs e)
        {
            FormLiquidarEmpleado formLiquidarEmpleado = new FormLiquidarEmpleado();
            formLiquidarEmpleado.Show();
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmpleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
