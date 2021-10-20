
namespace PayrollGUI
{
    partial class FormPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonas));
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.comboBoxEdad = new System.Windows.Forms.ComboBox();
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
            this.textBoxSueldo = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.textBoxIdentificacion = new System.Windows.Forms.TextBox();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModificar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlListado = new System.Windows.Forms.Panel();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListado = new System.Windows.Forms.Label();
            this.errorProviderRegistro = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlRegistro.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            this.pnlListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRegistro.Controls.Add(this.comboBoxEdad);
            this.pnlRegistro.Controls.Add(this.comboBoxCargo);
            this.pnlRegistro.Controls.Add(this.textBoxSueldo);
            this.pnlRegistro.Controls.Add(this.textBoxCorreo);
            this.pnlRegistro.Controls.Add(this.textBoxTelefono);
            this.pnlRegistro.Controls.Add(this.textBoxApellidos);
            this.pnlRegistro.Controls.Add(this.textBoxDireccion);
            this.pnlRegistro.Controls.Add(this.comboBoxTipo);
            this.pnlRegistro.Controls.Add(this.lblApellidos);
            this.pnlRegistro.Controls.Add(this.lblEdad);
            this.pnlRegistro.Controls.Add(this.textBoxIdentificacion);
            this.pnlRegistro.Controls.Add(this.textBoxNombres);
            this.pnlRegistro.Controls.Add(this.lblSueldo);
            this.pnlRegistro.Controls.Add(this.lblCorreo);
            this.pnlRegistro.Controls.Add(this.lblTelefono);
            this.pnlRegistro.Controls.Add(this.lblCargo);
            this.pnlRegistro.Controls.Add(this.lblDireccion);
            this.pnlRegistro.Controls.Add(this.lblTipo);
            this.pnlRegistro.Controls.Add(this.lblIdentificacion);
            this.pnlRegistro.Controls.Add(this.lblNombres);
            this.pnlRegistro.Controls.Add(this.lblRegistro);
            this.pnlRegistro.Location = new System.Drawing.Point(1, 3);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(535, 221);
            this.pnlRegistro.TabIndex = 31;
            this.pnlRegistro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegistro_Paint);
            // 
            // comboBoxEdad
            // 
            this.comboBoxEdad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxEdad.FormattingEnabled = true;
            this.comboBoxEdad.Items.AddRange(new object[] {
            "Seleccione",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28 ",
            "29 ",
            "30 ",
            "31 ",
            "32",
            "33 ",
            "34 ",
            "35",
            "36 ",
            "37 ",
            "38 ",
            "39 ",
            "40 ",
            "41",
            "42 ",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52 ",
            "53 ",
            "54 ",
            "55 ",
            "56 ",
            "57 ",
            "58 ",
            "59",
            "60"});
            this.comboBoxEdad.Location = new System.Drawing.Point(119, 120);
            this.comboBoxEdad.Name = "comboBoxEdad";
            this.comboBoxEdad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEdad.TabIndex = 43;
            this.comboBoxEdad.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdad_SelectedIndexChanged);
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Items.AddRange(new object[] {
            "Seleccione",
            "Servicio Publico",
            "Asesor Comercial",
            "Tecnico Informatico",
            "Recursos Humanos",
            "Comunicaciones",
            "Produccion",
            "Finanzas y Contabilidad",
            "Comercializacion y Ventas",
            "Gerente",
            "Supervisor",
            "Otro"});
            this.comboBoxCargo.Location = new System.Drawing.Point(391, 87);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCargo.TabIndex = 42;
            this.comboBoxCargo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCargo_SelectedIndexChanged);
            // 
            // textBoxSueldo
            // 
            this.textBoxSueldo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSueldo.Location = new System.Drawing.Point(391, 186);
            this.textBoxSueldo.Name = "textBoxSueldo";
            this.textBoxSueldo.Size = new System.Drawing.Size(121, 20);
            this.textBoxSueldo.TabIndex = 41;
            this.textBoxSueldo.TextChanged += new System.EventHandler(this.textBoxSueldo_TextChanged);
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCorreo.Location = new System.Drawing.Point(391, 152);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(121, 20);
            this.textBoxCorreo.TabIndex = 40;
            this.textBoxCorreo.TextChanged += new System.EventHandler(this.textBoxCorreo_TextChanged);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxTelefono.Location = new System.Drawing.Point(391, 121);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(121, 20);
            this.textBoxTelefono.TabIndex = 39;
            this.textBoxTelefono.TextChanged += new System.EventHandler(this.textBoxTelefono_TextChanged);
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxApellidos.Location = new System.Drawing.Point(119, 87);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(121, 20);
            this.textBoxApellidos.TabIndex = 38;
            this.textBoxApellidos.TextChanged += new System.EventHandler(this.textBoxApellidos_TextChanged);
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxDireccion.Location = new System.Drawing.Point(119, 186);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(121, 20);
            this.textBoxDireccion.TabIndex = 37;
            this.textBoxDireccion.TextChanged += new System.EventHandler(this.textBoxDireccion_TextChanged);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Selecione",
            "Empleado",
            "Pensionado"});
            this.comboBoxTipo.Location = new System.Drawing.Point(119, 152);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 36;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // lblApellidos
            // 
            this.lblApellidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(49, 88);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(74, 16);
            this.lblApellidos.TabIndex = 34;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblEdad
            // 
            this.lblEdad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(78, 122);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(45, 16);
            this.lblEdad.TabIndex = 33;
            this.lblEdad.Text = "Edad";
            // 
            // textBoxIdentificacion
            // 
            this.textBoxIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxIdentificacion.Location = new System.Drawing.Point(119, 54);
            this.textBoxIdentificacion.Name = "textBoxIdentificacion";
            this.textBoxIdentificacion.Size = new System.Drawing.Size(121, 20);
            this.textBoxIdentificacion.TabIndex = 32;
            this.textBoxIdentificacion.TextChanged += new System.EventHandler(this.textBoxIdentificacion_TextChanged);
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNombres.Location = new System.Drawing.Point(391, 54);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombres.TabIndex = 31;
            this.textBoxNombres.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // lblSueldo
            // 
            this.lblSueldo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(338, 187);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(57, 16);
            this.lblSueldo.TabIndex = 30;
            this.lblSueldo.Text = "Sueldo";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(259, 153);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(136, 16);
            this.lblCorreo.TabIndex = 29;
            this.lblCorreo.Text = "Correo electronico";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(325, 122);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(70, 16);
            this.lblTelefono.TabIndex = 28;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblCargo
            // 
            this.lblCargo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(345, 88);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(50, 16);
            this.lblCargo.TabIndex = 27;
            this.lblCargo.Text = "Cargo";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(49, 187);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(74, 16);
            this.lblDireccion.TabIndex = 26;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(0, 152);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(123, 16);
            this.lblTipo.TabIndex = 25;
            this.lblTipo.Text = "Tipo de persona";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(23, 54);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(100, 16);
            this.lblIdentificacion.TabIndex = 24;
            this.lblIdentificacion.Text = "Identificacion";
            // 
            // lblNombres
            // 
            this.lblNombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(324, 55);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(71, 16);
            this.lblNombres.TabIndex = 23;
            this.lblNombres.Text = "Nombres";
            // 
            // lblRegistro
            // 
            this.lblRegistro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRegistro.BackColor = System.Drawing.Color.Indigo;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegistro.Location = new System.Drawing.Point(256, 5);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(119, 35);
            this.lblRegistro.TabIndex = 22;
            this.lblRegistro.Text = " REGISTRO";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpciones.Controls.Add(this.lblOpciones);
            this.pnlOpciones.Controls.Add(this.btnEliminar);
            this.pnlOpciones.Controls.Add(this.btnModificar);
            this.pnlOpciones.Controls.Add(this.btnGuardar);
            this.pnlOpciones.Location = new System.Drawing.Point(539, 3);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(134, 221);
            this.pnlOpciones.TabIndex = 32;
            // 
            // lblOpciones
            // 
            this.lblOpciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOpciones.BackColor = System.Drawing.Color.Indigo;
            this.lblOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOpciones.Location = new System.Drawing.Point(4, 5);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(125, 35);
            this.lblOpciones.TabIndex = 43;
            this.lblOpciones.Text = " OPCIONES";
            this.lblOpciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderRadius = 0;
            this.btnEliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnEliminar.ButtonText = " ELIMINAR";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledColor = System.Drawing.Color.DarkOrange;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Iconimage")));
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 14;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = true;
            this.btnEliminar.IconZoom = 50D;
            this.btnEliminar.IsTab = true;
            this.btnEliminar.Location = new System.Drawing.Point(4, 110);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnEliminar.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(125, 40);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = " ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Textcolor = System.Drawing.Color.White;
            this.btnEliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnModificar
            // 
            this.btnModificar.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.BorderRadius = 0;
            this.btnModificar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnModificar.ButtonText = " MODIFICAR";
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.DisabledColor = System.Drawing.Color.DarkOrange;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModificar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModificar.Iconimage")));
            this.btnModificar.Iconimage_right = null;
            this.btnModificar.Iconimage_right_Selected = null;
            this.btnModificar.Iconimage_Selected = null;
            this.btnModificar.IconMarginLeft = 14;
            this.btnModificar.IconMarginRight = 0;
            this.btnModificar.IconRightVisible = true;
            this.btnModificar.IconRightZoom = 0D;
            this.btnModificar.IconVisible = true;
            this.btnModificar.IconZoom = 50D;
            this.btnModificar.IsTab = true;
            this.btnModificar.Location = new System.Drawing.Point(4, 155);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnModificar.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.btnModificar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModificar.selected = false;
            this.btnModificar.Size = new System.Drawing.Size(125, 40);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = " MODIFICAR";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Textcolor = System.Drawing.Color.White;
            this.btnModificar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnGuardar.ButtonText = " GUARDAR";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.DarkOrange;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Iconimage")));
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 14;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 50D;
            this.btnGuardar.IsTab = true;
            this.btnGuardar.Location = new System.Drawing.Point(4, 65);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.DarkOrange;
            this.btnGuardar.OnHovercolor = System.Drawing.Color.DarkOrange;
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(125, 40);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = " GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // pnlListado
            // 
            this.pnlListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListado.Controls.Add(this.dgvListado);
            this.pnlListado.Controls.Add(this.lblListado);
            this.pnlListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlListado.Location = new System.Drawing.Point(1, 227);
            this.pnlListado.Name = "pnlListado";
            this.pnlListado.Size = new System.Drawing.Size(672, 281);
            this.pnlListado.TabIndex = 33;
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificacion,
            this.Nombres,
            this.Apellidos,
            this.Cargo,
            this.Edad,
            this.Telefono,
            this.Tipo,
            this.Correo,
            this.Direccion,
            this.Sueldo});
            this.dgvListado.Location = new System.Drawing.Point(3, 52);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(664, 223);
            this.dgvListado.TabIndex = 33;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.Name = "Identificacion";
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo de persona";
            this.Tipo.Name = "Tipo";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo electronico";
            this.Correo.Name = "Correo";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            // 
            // lblListado
            // 
            this.lblListado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblListado.BackColor = System.Drawing.Color.Indigo;
            this.lblListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblListado.Location = new System.Drawing.Point(256, 4);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(119, 35);
            this.lblListado.TabIndex = 32;
            this.lblListado.Text = " LISTADO";
            this.lblListado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProviderRegistro
            // 
            this.errorProviderRegistro.ContainerControl = this;
            // 
            // FormPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(674, 510);
            this.Controls.Add(this.pnlListado);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPersonas";
            this.Text = "FormPersonas";
            this.Load += new System.EventHandler(this.FormPersonas_Load);
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.ComboBox comboBoxCargo;
        private System.Windows.Forms.TextBox textBoxSueldo;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox textBoxIdentificacion;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Panel pnlListado;
        private System.Windows.Forms.Label lblOpciones;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnModificar;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.ErrorProvider errorProviderRegistro;
        private System.Windows.Forms.ComboBox comboBoxEdad;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
    }
}