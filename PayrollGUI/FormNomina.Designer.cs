
namespace PayrollGUI
{
    partial class FormNomina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNomina));
            this.tabPersonas = new System.Windows.Forms.TabControl();
            this.tabPensionados = new System.Windows.Forms.TabPage();
            this.tabEmpleados = new System.Windows.Forms.TabPage();
            this.btnLiquidar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModificarEmpleado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarEmpleado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deducido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devengado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Basico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPersonas = new System.Windows.Forms.Panel();
            this.tabPersonas.SuspendLayout();
            this.tabEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.pnlPersonas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPersonas
            // 
            this.tabPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPersonas.Controls.Add(this.tabEmpleados);
            this.tabPersonas.Controls.Add(this.tabPensionados);
            this.tabPersonas.Location = new System.Drawing.Point(0, 0);
            this.tabPersonas.Name = "tabPersonas";
            this.tabPersonas.SelectedIndex = 0;
            this.tabPersonas.Size = new System.Drawing.Size(674, 510);
            this.tabPersonas.TabIndex = 0;
            // 
            // tabPensionados
            // 
            this.tabPensionados.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPensionados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPensionados.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPensionados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPensionados.Location = new System.Drawing.Point(4, 22);
            this.tabPensionados.Name = "tabPensionados";
            this.tabPensionados.Padding = new System.Windows.Forms.Padding(3);
            this.tabPensionados.Size = new System.Drawing.Size(666, 484);
            this.tabPensionados.TabIndex = 1;
            this.tabPensionados.Text = "Pensionados";
            // 
            // tabEmpleados
            // 
            this.tabEmpleados.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabEmpleados.Controls.Add(this.dgvEmpleados);
            this.tabEmpleados.Controls.Add(this.btnEliminarEmpleado);
            this.tabEmpleados.Controls.Add(this.btnModificarEmpleado);
            this.tabEmpleados.Controls.Add(this.btnLiquidar);
            this.tabEmpleados.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmpleados.ForeColor = System.Drawing.Color.Black;
            this.tabEmpleados.Location = new System.Drawing.Point(4, 22);
            this.tabEmpleados.Name = "tabEmpleados";
            this.tabEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpleados.Size = new System.Drawing.Size(666, 484);
            this.tabEmpleados.TabIndex = 0;
            this.tabEmpleados.Text = "Empleados";
            // 
            // btnLiquidar
            // 
            this.btnLiquidar.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnLiquidar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLiquidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLiquidar.BorderRadius = 0;
            this.btnLiquidar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnLiquidar.ButtonText = "          LIQUIDAR";
            this.btnLiquidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLiquidar.DisabledColor = System.Drawing.Color.DarkOrange;
            this.btnLiquidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiquidar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLiquidar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLiquidar.Iconimage")));
            this.btnLiquidar.Iconimage_right = null;
            this.btnLiquidar.Iconimage_right_Selected = null;
            this.btnLiquidar.Iconimage_Selected = null;
            this.btnLiquidar.IconMarginLeft = 14;
            this.btnLiquidar.IconMarginRight = 0;
            this.btnLiquidar.IconRightVisible = true;
            this.btnLiquidar.IconRightZoom = 0D;
            this.btnLiquidar.IconVisible = true;
            this.btnLiquidar.IconZoom = 50D;
            this.btnLiquidar.IsTab = true;
            this.btnLiquidar.Location = new System.Drawing.Point(297, 5);
            this.btnLiquidar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLiquidar.Name = "btnLiquidar";
            this.btnLiquidar.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnLiquidar.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.btnLiquidar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLiquidar.selected = false;
            this.btnLiquidar.Size = new System.Drawing.Size(120, 40);
            this.btnLiquidar.TabIndex = 32;
            this.btnLiquidar.Text = "          LIQUIDAR";
            this.btnLiquidar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLiquidar.Textcolor = System.Drawing.Color.White;
            this.btnLiquidar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiquidar.Click += new System.EventHandler(this.btnLiquidar_Click_1);
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnModificarEmpleado.BackColor = System.Drawing.Color.DarkOrange;
            this.btnModificarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarEmpleado.BorderRadius = 0;
            this.btnModificarEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnModificarEmpleado.ButtonText = "          MODIFICAR";
            this.btnModificarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarEmpleado.DisabledColor = System.Drawing.Color.DarkOrange;
            this.btnModificarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEmpleado.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModificarEmpleado.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModificarEmpleado.Iconimage")));
            this.btnModificarEmpleado.Iconimage_right = null;
            this.btnModificarEmpleado.Iconimage_right_Selected = null;
            this.btnModificarEmpleado.Iconimage_Selected = null;
            this.btnModificarEmpleado.IconMarginLeft = 14;
            this.btnModificarEmpleado.IconMarginRight = 0;
            this.btnModificarEmpleado.IconRightVisible = true;
            this.btnModificarEmpleado.IconRightZoom = 0D;
            this.btnModificarEmpleado.IconVisible = true;
            this.btnModificarEmpleado.IconZoom = 50D;
            this.btnModificarEmpleado.IsTab = true;
            this.btnModificarEmpleado.Location = new System.Drawing.Point(420, 5);
            this.btnModificarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnModificarEmpleado.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.btnModificarEmpleado.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModificarEmpleado.selected = false;
            this.btnModificarEmpleado.Size = new System.Drawing.Size(120, 40);
            this.btnModificarEmpleado.TabIndex = 31;
            this.btnModificarEmpleado.Text = "          MODIFICAR";
            this.btnModificarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarEmpleado.Textcolor = System.Drawing.Color.White;
            this.btnModificarEmpleado.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarEmpleado.BorderRadius = 0;
            this.btnEliminarEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnEliminarEmpleado.ButtonText = "          ELIMINAR";
            this.btnEliminarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEmpleado.DisabledColor = System.Drawing.Color.DarkOrange;
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpleado.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarEmpleado.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminarEmpleado.Iconimage")));
            this.btnEliminarEmpleado.Iconimage_right = null;
            this.btnEliminarEmpleado.Iconimage_right_Selected = null;
            this.btnEliminarEmpleado.Iconimage_Selected = null;
            this.btnEliminarEmpleado.IconMarginLeft = 14;
            this.btnEliminarEmpleado.IconMarginRight = 0;
            this.btnEliminarEmpleado.IconRightVisible = true;
            this.btnEliminarEmpleado.IconRightZoom = 0D;
            this.btnEliminarEmpleado.IconVisible = true;
            this.btnEliminarEmpleado.IconZoom = 50D;
            this.btnEliminarEmpleado.IsTab = true;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(543, 5);
            this.btnEliminarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnEliminarEmpleado.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.btnEliminarEmpleado.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarEmpleado.selected = false;
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(120, 40);
            this.btnEliminarEmpleado.TabIndex = 30;
            this.btnEliminarEmpleado.Text = "          ELIMINAR";
            this.btnEliminarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEmpleado.Textcolor = System.Drawing.Color.White;
            this.btnEliminarEmpleado.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificacion,
            this.Empleados,
            this.Sueldo,
            this.Dias,
            this.Basico,
            this.Transporte,
            this.Devengado,
            this.Salud,
            this.Pension,
            this.Deducido,
            this.Neto});
            this.dgvEmpleados.Location = new System.Drawing.Point(1, 50);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(662, 431);
            this.dgvEmpleados.TabIndex = 35;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick_1);
            // 
            // Neto
            // 
            this.Neto.HeaderText = "Total neto";
            this.Neto.Name = "Neto";
            // 
            // Deducido
            // 
            this.Deducido.HeaderText = "Total deducido";
            this.Deducido.Name = "Deducido";
            // 
            // Pension
            // 
            this.Pension.HeaderText = "Pension";
            this.Pension.Name = "Pension";
            // 
            // Salud
            // 
            this.Salud.HeaderText = "Salud";
            this.Salud.Name = "Salud";
            // 
            // Devengado
            // 
            this.Devengado.HeaderText = "Total devengado";
            this.Devengado.Name = "Devengado";
            // 
            // Transporte
            // 
            this.Transporte.HeaderText = "Auxiliar de transporte";
            this.Transporte.Name = "Transporte";
            // 
            // Basico
            // 
            this.Basico.HeaderText = "Sueldo basico";
            this.Basico.Name = "Basico";
            // 
            // Dias
            // 
            this.Dias.HeaderText = "Dias trabajados";
            this.Dias.Name = "Dias";
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            // 
            // Empleados
            // 
            this.Empleados.HeaderText = "Empleados";
            this.Empleados.Name = "Empleados";
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.Name = "Identificacion";
            // 
            // pnlPersonas
            // 
            this.pnlPersonas.Controls.Add(this.tabPersonas);
            this.pnlPersonas.Location = new System.Drawing.Point(0, 1);
            this.pnlPersonas.Name = "pnlPersonas";
            this.pnlPersonas.Size = new System.Drawing.Size(674, 510);
            this.pnlPersonas.TabIndex = 2;
            this.pnlPersonas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPersonas_Paint);
            // 
            // FormNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(674, 510);
            this.Controls.Add(this.pnlPersonas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNomina";
            this.Text = "FormNomina";
            this.tabPersonas.ResumeLayout(false);
            this.tabEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.pnlPersonas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPersonas;
        private System.Windows.Forms.TabPage tabEmpleados;
        public System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Basico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devengado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pension;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deducido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarEmpleado;
        private Bunifu.Framework.UI.BunifuFlatButton btnModificarEmpleado;
        private Bunifu.Framework.UI.BunifuFlatButton btnLiquidar;
        private System.Windows.Forms.TabPage tabPensionados;
        private System.Windows.Forms.Panel pnlPersonas;
    }
}