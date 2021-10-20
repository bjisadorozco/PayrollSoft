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
    public partial class FormPersonas : Form
    {
        public FormPersonas()
        {
            InitializeComponent();
        }
        private bool validarCampos()
        {
            bool is_valid = true;
            if (textBoxIdentificacion.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(textBoxIdentificacion, "Digite su identificacion");
            }
            if (textBoxNombres.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(textBoxNombres, "Digite su nombre");
            }
            if (textBoxApellidos.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(textBoxApellidos, "Digite su apellido");
            }
            if (comboBoxCargo.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(comboBoxCargo, "Seleccione su cargo");
            }
            if (comboBoxEdad.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(comboBoxEdad, "Seleccione su edad");
            }
            if (textBoxTelefono.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(textBoxTelefono, "Digite su telefono");
            }
            if (comboBoxTipo.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(comboBoxTipo, "Seleccione su tipo de persona");
            }
            if (textBoxCorreo.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(textBoxCorreo, "Digite su correo electronico");
            }
            if (textBoxDireccion.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(textBoxDireccion, "Digite su direccion");
            }
            if (textBoxSueldo.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(textBoxSueldo, "Digite su sueldo");
            }
            return is_valid;
        }
        public void borrarMensajesErrorProvider()
        {
            errorProviderRegistro.SetError(textBoxIdentificacion, "");
            errorProviderRegistro.SetError(textBoxNombres, "");
            errorProviderRegistro.SetError(textBoxApellidos, "");
            errorProviderRegistro.SetError(comboBoxCargo, "");
            errorProviderRegistro.SetError(comboBoxEdad, "");
            errorProviderRegistro.SetError(textBoxTelefono, "");
            errorProviderRegistro.SetError(comboBoxTipo, "");
            errorProviderRegistro.SetError(textBoxCorreo, "");
            errorProviderRegistro.SetError(textBoxDireccion, "");
            errorProviderRegistro.SetError(textBoxSueldo, "");
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            
            if (!textBoxNombres.Equals(""))
            {
                errorProviderRegistro.SetError(textBoxNombres, "");
            }
        }

        private void FormPersonas_Load(object sender, EventArgs e)
        {

        }

        private void pnlRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                DataGridViewRow fila = new DataGridViewRow(); //creo el objeto fila, para buscar por fila
                fila.CreateCells(dgvListado); //creo las celdas en mi dgv listado
                fila.Cells[0].Value = textBoxIdentificacion.Text;
                fila.Cells[1].Value = textBoxNombres.Text;
                fila.Cells[2].Value = textBoxApellidos.Text;
                fila.Cells[3].Value = comboBoxCargo.Text;
                fila.Cells[4].Value = comboBoxEdad.Text;
                fila.Cells[5].Value = textBoxTelefono.Text;
                fila.Cells[6].Value = comboBoxTipo.Text;
                fila.Cells[7].Value = textBoxCorreo.Text;
                fila.Cells[8].Value = textBoxDireccion.Text;
                fila.Cells[9].Value = textBoxSueldo.Text;
               
                dgvListado.Rows.Add(fila);
                textBoxIdentificacion.Text = textBoxNombres.Text = textBoxApellidos.Text = comboBoxCargo.Text = comboBoxEdad.Text = textBoxTelefono.Text = comboBoxTipo.Text = textBoxCorreo.Text = textBoxDireccion.Text = textBoxSueldo.Text = "";
                borrarMensajesErrorProvider();
            }
        }

        private void comboBoxEdad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int edad;
            if (!int.TryParse(comboBoxEdad.Text, out edad))
            {
                errorProviderRegistro.SetError(comboBoxEdad, "Seleccione valores numericos");
            }
            else
            {
                errorProviderRegistro.SetError(comboBoxEdad, "");
            }
        }

        private void textBoxIdentificacion_TextChanged(object sender, EventArgs e)
        {
            int identificacion;
            if (!int.TryParse(textBoxIdentificacion.Text, out identificacion))
            {
                errorProviderRegistro.SetError(textBoxIdentificacion, "Ingrese valores numericos");
            }
            else
            {
                errorProviderRegistro.SetError(textBoxIdentificacion, "");
            }
        }

        private void textBoxApellidos_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxApellidos.Equals(""))
            {
                errorProviderRegistro.SetError(textBoxApellidos, "");
            }
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            long telefono;
            if (!long.TryParse(textBoxTelefono.Text, out telefono))
            {
                errorProviderRegistro.SetError(textBoxTelefono, "Ingrese valores numericos");
            }
            else
            {
                errorProviderRegistro.SetError(textBoxTelefono, "");
            }
        }

        private void textBoxSueldo_TextChanged(object sender, EventArgs e)
        {
            double sueldo;
            if (!double.TryParse(textBoxSueldo.Text, out sueldo))
            {
                errorProviderRegistro.SetError(textBoxSueldo, "Ingrese valores numericos");
            }
            else
            {
                errorProviderRegistro.SetError(textBoxSueldo, "");
            }
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBoxCargo.Equals(""))
            {
                errorProviderRegistro.SetError(comboBoxCargo, "");
            }
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBoxTipo.Equals(""))
            {
                errorProviderRegistro.SetError(comboBoxTipo, "");
            }
        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxCorreo.Equals(""))
            {
                errorProviderRegistro.SetError(textBoxCorreo, "");
            }
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxDireccion.Equals(""))
            {
                errorProviderRegistro.SetError(textBoxDireccion, "");
            }
        }
    }
}