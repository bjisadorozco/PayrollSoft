
namespace PayrollGUI
{
    partial class FormLiquidarEmpleado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLiquidarEmpleado));
            this.pnlLiquidarEmpleado = new System.Windows.Forms.Panel();
            this.lblLiquidarEmpleado = new System.Windows.Forms.Label();
            this.btnCalcular = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRegresar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLiquidarEmpleado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBoxNeto = new System.Windows.Forms.TextBox();
            this.textBoxDeducido = new System.Windows.Forms.TextBox();
            this.textBoxPension = new System.Windows.Forms.TextBox();
            this.textBoxSalud = new System.Windows.Forms.TextBox();
            this.textBoxDevengado = new System.Windows.Forms.TextBox();
            this.textBoxTransporte = new System.Windows.Forms.TextBox();
            this.lblTotalNeto = new System.Windows.Forms.Label();
            this.lblTotalDeducido = new System.Windows.Forms.Label();
            this.lblPension = new System.Windows.Forms.Label();
            this.lblSalud = new System.Windows.Forms.Label();
            this.lblTotalDevengado = new System.Windows.Forms.Label();
            this.lblsAuxiliarTransporte = new System.Windows.Forms.Label();
            this.textBoxBasico = new System.Windows.Forms.TextBox();
            this.lblSueldoBasico = new System.Windows.Forms.Label();
            this.textBoxDias = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.textBoxEmpleado = new System.Windows.Forms.TextBox();
            this.lblEmpleadoEncontrado = new System.Windows.Forms.Label();
            this.textBoxSueldo = new System.Windows.Forms.TextBox();
            this.lblSueldoEncontrado = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.lblIdentificacionLiquidar = new System.Windows.Forms.Label();
            this.errorProviderLiquidarEmpleado = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlLiquidarEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLiquidarEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLiquidarEmpleado
            // 
            this.pnlLiquidarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLiquidarEmpleado.BackColor = System.Drawing.Color.White;
            this.pnlLiquidarEmpleado.Controls.Add(this.lblLiquidarEmpleado);
            this.pnlLiquidarEmpleado.Controls.Add(this.btnCalcular);
            this.pnlLiquidarEmpleado.Controls.Add(this.btnRegresar);
            this.pnlLiquidarEmpleado.Controls.Add(this.btnLiquidarEmpleado);
            this.pnlLiquidarEmpleado.Controls.Add(this.textBoxNeto);
            this.pnlLiquidarEmpleado.Controls.Add(this.textBoxDeducido);
            this.pnlLiquidarEmpleado.Controls.Add(this.textBoxPension);
            this.pnlLiquidarEmpleado.Controls.Add(this.textBoxSalud);
            this.pnlLiquidarEmpleado.Controls.Add(this.textBoxDevengado);
            this.pnlLiquidarEmpleado.Controls.Add(this.textBoxTransporte);
            this.pnlLiquidarEmpleado.Controls.Add(this.lblTotalNeto);
            this.pnlLiquidarEmpleado.Controls.Add(this.lblTotalDeducido);
            this.pnlLiquidarEmpleado.Controls.Add(this.lblPension);
            this.pnlLiquidarEmpleado.Controls.Add(this.lblSalud);
            this.pnlLiquidarEmpleado.Controls.Add(this.lblTotalDevengado);
            this.pnlLiquidarEmpleado.Controls.Add(this.lblsAuxiliarTransporte);
            this.pnlLiquidarEmpleado.Controls.Add(this.textBoxBasico);
            this.pnlLiquidarEmpleado.Controls.Add(this.lblSueldoBasico);
            this.pnlLiquidarEmpleado.Controls.Add(this.textBoxDias);
            this.pnlLiquidarEmpleado.Controls.Add(this.lblDias);
            this.pnlLiquidarEmpleado.Controls.Add(this.textBoxEmpleado);
            this.pnlLiquidarEmpleado.Controls.Add(this.lblEmpleadoEncontrado);
            this.pnlLiquidarEmpleado.Controls.Add(this.textBoxSueldo);
            this.pnlLiquidarEmpleado.Controls.Add(this.lblSueldoEncontrado);
            this.pnlLiquidarEmpleado.Controls.Add(this.textBoxID);
            this.pnlLiquidarEmpleado.Controls.Add(this.lblIdentificacionLiquidar);
            this.pnlLiquidarEmpleado.Location = new System.Drawing.Point(0, 0);
            this.pnlLiquidarEmpleado.Name = "pnlLiquidarEmpleado";
            this.pnlLiquidarEmpleado.Size = new System.Drawing.Size(407, 413);
            this.pnlLiquidarEmpleado.TabIndex = 0;
            this.pnlLiquidarEmpleado.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLiquidarEmpleado_Paint);
            // 
            // lblLiquidarEmpleado
            // 
            this.lblLiquidarEmpleado.BackColor = System.Drawing.Color.Indigo;
            this.lblLiquidarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiquidarEmpleado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLiquidarEmpleado.Location = new System.Drawing.Point(101, 9);
            this.lblLiquidarEmpleado.Name = "lblLiquidarEmpleado";
            this.lblLiquidarEmpleado.Size = new System.Drawing.Size(203, 29);
            this.lblLiquidarEmpleado.TabIndex = 36;
            this.lblLiquidarEmpleado.Text = "LIQUIDAR EMPLEADO";
            this.lblLiquidarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnCalcular.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalcular.BorderRadius = 0;
            this.btnCalcular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCalcular.ButtonText = "CALCULAR";
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.DisabledColor = System.Drawing.Color.DarkOrange;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCalcular.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Iconimage")));
            this.btnCalcular.Iconimage_right = null;
            this.btnCalcular.Iconimage_right_Selected = null;
            this.btnCalcular.Iconimage_Selected = null;
            this.btnCalcular.IconMarginLeft = 7;
            this.btnCalcular.IconMarginRight = 0;
            this.btnCalcular.IconRightVisible = true;
            this.btnCalcular.IconRightZoom = 0D;
            this.btnCalcular.IconVisible = true;
            this.btnCalcular.IconZoom = 50D;
            this.btnCalcular.IsTab = true;
            this.btnCalcular.Location = new System.Drawing.Point(289, 306);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnCalcular.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.btnCalcular.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCalcular.selected = false;
            this.btnCalcular.Size = new System.Drawing.Size(112, 37);
            this.btnCalcular.TabIndex = 35;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Textcolor = System.Drawing.Color.White;
            this.btnCalcular.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnRegresar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.BorderRadius = 0;
            this.btnRegresar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRegresar.ButtonText = "REGRESAR";
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.DisabledColor = System.Drawing.Color.DarkOrange;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegresar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Iconimage")));
            this.btnRegresar.Iconimage_right = null;
            this.btnRegresar.Iconimage_right_Selected = null;
            this.btnRegresar.Iconimage_Selected = null;
            this.btnRegresar.IconMarginLeft = 14;
            this.btnRegresar.IconMarginRight = 0;
            this.btnRegresar.IconRightVisible = true;
            this.btnRegresar.IconRightZoom = 0D;
            this.btnRegresar.IconVisible = true;
            this.btnRegresar.IconZoom = 50D;
            this.btnRegresar.IsTab = true;
            this.btnRegresar.Location = new System.Drawing.Point(218, 357);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnRegresar.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.btnRegresar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegresar.selected = false;
            this.btnRegresar.Size = new System.Drawing.Size(123, 40);
            this.btnRegresar.TabIndex = 34;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Textcolor = System.Drawing.Color.White;
            this.btnRegresar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnLiquidarEmpleado
            // 
            this.btnLiquidarEmpleado.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnLiquidarEmpleado.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLiquidarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLiquidarEmpleado.BorderRadius = 0;
            this.btnLiquidarEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnLiquidarEmpleado.ButtonText = "LIQUIDAR";
            this.btnLiquidarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLiquidarEmpleado.DisabledColor = System.Drawing.Color.DarkOrange;
            this.btnLiquidarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiquidarEmpleado.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLiquidarEmpleado.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLiquidarEmpleado.Iconimage")));
            this.btnLiquidarEmpleado.Iconimage_right = null;
            this.btnLiquidarEmpleado.Iconimage_right_Selected = null;
            this.btnLiquidarEmpleado.Iconimage_Selected = null;
            this.btnLiquidarEmpleado.IconMarginLeft = 14;
            this.btnLiquidarEmpleado.IconMarginRight = 0;
            this.btnLiquidarEmpleado.IconRightVisible = true;
            this.btnLiquidarEmpleado.IconRightZoom = 0D;
            this.btnLiquidarEmpleado.IconVisible = true;
            this.btnLiquidarEmpleado.IconZoom = 50D;
            this.btnLiquidarEmpleado.IsTab = true;
            this.btnLiquidarEmpleado.Location = new System.Drawing.Point(80, 357);
            this.btnLiquidarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnLiquidarEmpleado.Name = "btnLiquidarEmpleado";
            this.btnLiquidarEmpleado.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnLiquidarEmpleado.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.btnLiquidarEmpleado.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLiquidarEmpleado.selected = false;
            this.btnLiquidarEmpleado.Size = new System.Drawing.Size(123, 40);
            this.btnLiquidarEmpleado.TabIndex = 33;
            this.btnLiquidarEmpleado.Text = "LIQUIDAR";
            this.btnLiquidarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLiquidarEmpleado.Textcolor = System.Drawing.Color.White;
            this.btnLiquidarEmpleado.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiquidarEmpleado.Click += new System.EventHandler(this.btnLiquidarEmpleado_Click);
            // 
            // textBoxNeto
            // 
            this.textBoxNeto.Enabled = false;
            this.textBoxNeto.Location = new System.Drawing.Point(164, 314);
            this.textBoxNeto.Name = "textBoxNeto";
            this.textBoxNeto.Size = new System.Drawing.Size(120, 20);
            this.textBoxNeto.TabIndex = 21;
            // 
            // textBoxDeducido
            // 
            this.textBoxDeducido.Enabled = false;
            this.textBoxDeducido.Location = new System.Drawing.Point(164, 288);
            this.textBoxDeducido.Name = "textBoxDeducido";
            this.textBoxDeducido.Size = new System.Drawing.Size(120, 20);
            this.textBoxDeducido.TabIndex = 20;
            // 
            // textBoxPension
            // 
            this.textBoxPension.Enabled = false;
            this.textBoxPension.Location = new System.Drawing.Point(164, 262);
            this.textBoxPension.Name = "textBoxPension";
            this.textBoxPension.Size = new System.Drawing.Size(120, 20);
            this.textBoxPension.TabIndex = 19;
            // 
            // textBoxSalud
            // 
            this.textBoxSalud.Enabled = false;
            this.textBoxSalud.Location = new System.Drawing.Point(164, 237);
            this.textBoxSalud.Name = "textBoxSalud";
            this.textBoxSalud.Size = new System.Drawing.Size(120, 20);
            this.textBoxSalud.TabIndex = 18;
            // 
            // textBoxDevengado
            // 
            this.textBoxDevengado.Enabled = false;
            this.textBoxDevengado.Location = new System.Drawing.Point(164, 212);
            this.textBoxDevengado.Name = "textBoxDevengado";
            this.textBoxDevengado.Size = new System.Drawing.Size(120, 20);
            this.textBoxDevengado.TabIndex = 17;
            // 
            // textBoxTransporte
            // 
            this.textBoxTransporte.Enabled = false;
            this.textBoxTransporte.Location = new System.Drawing.Point(164, 187);
            this.textBoxTransporte.Name = "textBoxTransporte";
            this.textBoxTransporte.Size = new System.Drawing.Size(120, 20);
            this.textBoxTransporte.TabIndex = 16;
            // 
            // lblTotalNeto
            // 
            this.lblTotalNeto.AutoSize = true;
            this.lblTotalNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNeto.Location = new System.Drawing.Point(77, 315);
            this.lblTotalNeto.Name = "lblTotalNeto";
            this.lblTotalNeto.Size = new System.Drawing.Size(81, 16);
            this.lblTotalNeto.TabIndex = 15;
            this.lblTotalNeto.Text = "Total Neto";
            // 
            // lblTotalDeducido
            // 
            this.lblTotalDeducido.AutoSize = true;
            this.lblTotalDeducido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeducido.Location = new System.Drawing.Point(45, 289);
            this.lblTotalDeducido.Name = "lblTotalDeducido";
            this.lblTotalDeducido.Size = new System.Drawing.Size(113, 16);
            this.lblTotalDeducido.TabIndex = 14;
            this.lblTotalDeducido.Text = "Total deducido";
            // 
            // lblPension
            // 
            this.lblPension.AutoSize = true;
            this.lblPension.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPension.Location = new System.Drawing.Point(94, 263);
            this.lblPension.Name = "lblPension";
            this.lblPension.Size = new System.Drawing.Size(64, 16);
            this.lblPension.TabIndex = 13;
            this.lblPension.Text = "Pension";
            // 
            // lblSalud
            // 
            this.lblSalud.AutoSize = true;
            this.lblSalud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalud.Location = new System.Drawing.Point(110, 238);
            this.lblSalud.Name = "lblSalud";
            this.lblSalud.Size = new System.Drawing.Size(48, 16);
            this.lblSalud.TabIndex = 12;
            this.lblSalud.Text = "Salud";
            // 
            // lblTotalDevengado
            // 
            this.lblTotalDevengado.AutoSize = true;
            this.lblTotalDevengado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDevengado.Location = new System.Drawing.Point(31, 213);
            this.lblTotalDevengado.Name = "lblTotalDevengado";
            this.lblTotalDevengado.Size = new System.Drawing.Size(127, 16);
            this.lblTotalDevengado.TabIndex = 11;
            this.lblTotalDevengado.Text = "Total devengado";
            // 
            // lblsAuxiliarTransporte
            // 
            this.lblsAuxiliarTransporte.AutoSize = true;
            this.lblsAuxiliarTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsAuxiliarTransporte.Location = new System.Drawing.Point(3, 188);
            this.lblsAuxiliarTransporte.Name = "lblsAuxiliarTransporte";
            this.lblsAuxiliarTransporte.Size = new System.Drawing.Size(155, 16);
            this.lblsAuxiliarTransporte.TabIndex = 10;
            this.lblsAuxiliarTransporte.Text = "Auxiliar de transporte";
            // 
            // textBoxBasico
            // 
            this.textBoxBasico.Enabled = false;
            this.textBoxBasico.Location = new System.Drawing.Point(164, 162);
            this.textBoxBasico.Name = "textBoxBasico";
            this.textBoxBasico.Size = new System.Drawing.Size(120, 20);
            this.textBoxBasico.TabIndex = 9;
            // 
            // lblSueldoBasico
            // 
            this.lblSueldoBasico.AutoSize = true;
            this.lblSueldoBasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoBasico.Location = new System.Drawing.Point(50, 163);
            this.lblSueldoBasico.Name = "lblSueldoBasico";
            this.lblSueldoBasico.Size = new System.Drawing.Size(108, 16);
            this.lblSueldoBasico.TabIndex = 8;
            this.lblSueldoBasico.Text = "Sueldo basico";
            // 
            // textBoxDias
            // 
            this.textBoxDias.Location = new System.Drawing.Point(164, 134);
            this.textBoxDias.Name = "textBoxDias";
            this.textBoxDias.Size = new System.Drawing.Size(120, 20);
            this.textBoxDias.TabIndex = 7;
            this.textBoxDias.TextChanged += new System.EventHandler(this.textBoxDias_TextChanged);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(39, 135);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(119, 16);
            this.lblDias.TabIndex = 6;
            this.lblDias.Text = "Dias trabajados";
            // 
            // textBoxEmpleado
            // 
            this.textBoxEmpleado.Location = new System.Drawing.Point(164, 83);
            this.textBoxEmpleado.Name = "textBoxEmpleado";
            this.textBoxEmpleado.Size = new System.Drawing.Size(120, 20);
            this.textBoxEmpleado.TabIndex = 5;
            this.textBoxEmpleado.TextChanged += new System.EventHandler(this.textBoxEmpleado_TextChanged);
            // 
            // lblEmpleadoEncontrado
            // 
            this.lblEmpleadoEncontrado.AutoSize = true;
            this.lblEmpleadoEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadoEncontrado.Location = new System.Drawing.Point(79, 84);
            this.lblEmpleadoEncontrado.Name = "lblEmpleadoEncontrado";
            this.lblEmpleadoEncontrado.Size = new System.Drawing.Size(79, 16);
            this.lblEmpleadoEncontrado.TabIndex = 4;
            this.lblEmpleadoEncontrado.Text = "Empleado";
            // 
            // textBoxSueldo
            // 
            this.textBoxSueldo.Location = new System.Drawing.Point(164, 109);
            this.textBoxSueldo.Name = "textBoxSueldo";
            this.textBoxSueldo.Size = new System.Drawing.Size(120, 20);
            this.textBoxSueldo.TabIndex = 3;
            this.textBoxSueldo.TextChanged += new System.EventHandler(this.textBoxSueldo_TextChanged);
            // 
            // lblSueldoEncontrado
            // 
            this.lblSueldoEncontrado.AutoSize = true;
            this.lblSueldoEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoEncontrado.Location = new System.Drawing.Point(101, 110);
            this.lblSueldoEncontrado.Name = "lblSueldoEncontrado";
            this.lblSueldoEncontrado.Size = new System.Drawing.Size(57, 16);
            this.lblSueldoEncontrado.TabIndex = 2;
            this.lblSueldoEncontrado.Text = "Sueldo";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(164, 57);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(120, 20);
            this.textBoxID.TabIndex = 1;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // lblIdentificacionLiquidar
            // 
            this.lblIdentificacionLiquidar.AutoSize = true;
            this.lblIdentificacionLiquidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacionLiquidar.Location = new System.Drawing.Point(58, 58);
            this.lblIdentificacionLiquidar.Name = "lblIdentificacionLiquidar";
            this.lblIdentificacionLiquidar.Size = new System.Drawing.Size(100, 16);
            this.lblIdentificacionLiquidar.TabIndex = 0;
            this.lblIdentificacionLiquidar.Text = "Identificacion";
            // 
            // errorProviderLiquidarEmpleado
            // 
            this.errorProviderLiquidarEmpleado.ContainerControl = this;
            // 
            // FormLiquidarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 413);
            this.Controls.Add(this.pnlLiquidarEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(560, 194);
            this.Name = "FormLiquidarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormLiquidarEmpleado";
            this.pnlLiquidarEmpleado.ResumeLayout(false);
            this.pnlLiquidarEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLiquidarEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLiquidarEmpleado;
        private System.Windows.Forms.Label lblEmpleadoEncontrado;
        private System.Windows.Forms.Label lblSueldoEncontrado;
        private System.Windows.Forms.Label lblIdentificacionLiquidar;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblTotalNeto;
        private System.Windows.Forms.Label lblTotalDeducido;
        private System.Windows.Forms.Label lblPension;
        private System.Windows.Forms.Label lblSalud;
        private System.Windows.Forms.Label lblTotalDevengado;
        private System.Windows.Forms.Label lblsAuxiliarTransporte;
        private System.Windows.Forms.Label lblSueldoBasico;
        private Bunifu.Framework.UI.BunifuFlatButton btnLiquidarEmpleado;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegresar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalcular;
        private System.Windows.Forms.Label lblLiquidarEmpleado;
        private System.Windows.Forms.ErrorProvider errorProviderLiquidarEmpleado;
        public System.Windows.Forms.TextBox textBoxSueldo;
        public System.Windows.Forms.TextBox textBoxID;
        public System.Windows.Forms.TextBox textBoxEmpleado;
        public System.Windows.Forms.TextBox textBoxDias;
        public System.Windows.Forms.TextBox textBoxNeto;
        public System.Windows.Forms.TextBox textBoxDeducido;
        public System.Windows.Forms.TextBox textBoxPension;
        public System.Windows.Forms.TextBox textBoxSalud;
        public System.Windows.Forms.TextBox textBoxDevengado;
        public System.Windows.Forms.TextBox textBoxTransporte;
        public System.Windows.Forms.TextBox textBoxBasico;
    }
}