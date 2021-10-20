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
    public partial class FormLiquidarEmpleado : Form
    {
        public FormLiquidarEmpleado()
        {
            InitializeComponent();
        }
        private bool validarCampos()
        {
            bool is_valid = true;
            if (textBoxID.Text == string.Empty)
            {
                is_valid = false;
                errorProviderLiquidarEmpleado.SetError(textBoxID, "Digite la identificacion");
            }
            if (textBoxEmpleado.Text == string.Empty)
            {
                is_valid = false;
                errorProviderLiquidarEmpleado.SetError(textBoxEmpleado, "Digite el sueldo");
            }
            if (textBoxSueldo.Text == string.Empty)
            {
                is_valid = false;
                errorProviderLiquidarEmpleado.SetError(textBoxSueldo, "Digite el sueldo");
            }
            if (textBoxDias.Text == string.Empty)
            {
                is_valid = false;
                errorProviderLiquidarEmpleado.SetError(textBoxDias, "Digite los dias trabajados");
            }
            return is_valid;
        }
        public void borrarMensajesErrorProvider()
        {
            errorProviderLiquidarEmpleado.SetError(textBoxID, "");
            errorProviderLiquidarEmpleado.SetError(textBoxEmpleado, "");
            errorProviderLiquidarEmpleado.SetError(textBoxSueldo, "");
            errorProviderLiquidarEmpleado.SetError(textBoxDias, "");
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                borrarMensajesErrorProvider();
            }
        }
        

        private void btnLiquidarEmpleado_Click(object sender, EventArgs e)
        { 
                if (validarCampos())
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    FormNomina llamar = new FormNomina();
                    fila.CreateCells(llamar.dgvEmpleados);
                    fila.Cells[0].Value = textBoxID.Text;
                    fila.Cells[1].Value = textBoxEmpleado.Text;
                    fila.Cells[2].Value = textBoxSueldo.Text;
                    fila.Cells[3].Value = textBoxDias.Text;
                    fila.Cells[4].Value = textBoxBasico.Text;
                    fila.Cells[5].Value = textBoxTransporte;
                    fila.Cells[6].Value = textBoxDevengado.Text;
                    fila.Cells[7].Value = textBoxSalud.Text;
                    fila.Cells[8].Value = textBoxPension.Text;
                    fila.Cells[9].Value = textBoxDeducido.Text;
                    fila.Cells[10].Value = textBoxNeto.Text;

                    llamar.dgvEmpleados.Rows.Add(fila);

                    textBoxID.Text = textBoxEmpleado.Text = textBoxSueldo.Text = textBoxDias.Text = "";
                    borrarMensajesErrorProvider();
                }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxDias_TextChanged(object sender, EventArgs e)
        {
            int dias;
            if (!int.TryParse(textBoxDias.Text, out dias))
            {
                errorProviderLiquidarEmpleado.SetError(textBoxDias, "Ingrese valores numericos");
            }
            else
            {
                errorProviderLiquidarEmpleado.SetError(textBoxDias, "");
            }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(textBoxID.Text, out id))
            {
                errorProviderLiquidarEmpleado.SetError(textBoxID, "Ingrese valores numericos");
            }
            else
            {
                errorProviderLiquidarEmpleado.SetError(textBoxID, "");
            }
        }

        private void textBoxEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxEmpleado.Equals(""))
            {
                errorProviderLiquidarEmpleado.SetError(textBoxEmpleado, "");
            }
        }

        private void textBoxSueldo_TextChanged(object sender, EventArgs e)
        {
            double sueldo;
            if (!double.TryParse(textBoxSueldo.Text, out sueldo))
            {
                errorProviderLiquidarEmpleado.SetError(textBoxSueldo, "Ingrese valores numericos");
            }
            else
            {
                errorProviderLiquidarEmpleado.SetError(textBoxSueldo, "");
            }
        }

        private void pnlLiquidarEmpleado_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
