
namespace PayrollGUI
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pnlApartados = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.pnlVista = new System.Windows.Forms.Panel();
            this.btnInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnNomina = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPersonas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmpresa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAjustes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBoxSalir = new System.Windows.Forms.PictureBox();
            this.pnlApartados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlApartados
            // 
            this.pnlApartados.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlApartados.Controls.Add(this.pictureBoxSalir);
            this.pnlApartados.Controls.Add(this.panel3);
            this.pnlApartados.Controls.Add(this.btnAjustes);
            this.pnlApartados.Controls.Add(this.panel1);
            this.pnlApartados.Controls.Add(this.btnEmpresa);
            this.pnlApartados.Controls.Add(this.panel2);
            this.pnlApartados.Controls.Add(this.btnReportes);
            this.pnlApartados.Controls.Add(this.panel4);
            this.pnlApartados.Controls.Add(this.btnPersonas);
            this.pnlApartados.Controls.Add(this.panel6);
            this.pnlApartados.Controls.Add(this.btnNomina);
            this.pnlApartados.Controls.Add(this.panel5);
            this.pnlApartados.Controls.Add(this.btnInicio);
            this.pnlApartados.Controls.Add(this.pictureLogo);
            this.pnlApartados.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlApartados.Location = new System.Drawing.Point(0, 0);
            this.pnlApartados.Name = "pnlApartados";
            this.pnlApartados.Size = new System.Drawing.Size(164, 510);
            this.pnlApartados.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(164, 135);
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.Click += new System.EventHandler(this.pictureLogo_Click);
            // 
            // pnlVista
            // 
            this.pnlVista.BackColor = System.Drawing.SystemColors.Control;
            this.pnlVista.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVista.Location = new System.Drawing.Point(164, 0);
            this.pnlVista.Name = "pnlVista";
            this.pnlVista.Size = new System.Drawing.Size(674, 510);
            this.pnlVista.TabIndex = 1;
            this.pnlVista.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVista_Paint);
            // 
            // btnInicio
            // 
            this.btnInicio.Activecolor = System.Drawing.Color.Transparent;
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.BorderRadius = 0;
            this.btnInicio.ButtonText = "    INICIO";
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.DisabledColor = System.Drawing.Color.Gray;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInicio.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInicio.Iconimage")));
            this.btnInicio.Iconimage_right = null;
            this.btnInicio.Iconimage_right_Selected = null;
            this.btnInicio.Iconimage_Selected = null;
            this.btnInicio.IconMarginLeft = 20;
            this.btnInicio.IconMarginRight = 0;
            this.btnInicio.IconRightVisible = true;
            this.btnInicio.IconRightZoom = 0D;
            this.btnInicio.IconVisible = true;
            this.btnInicio.IconZoom = 65D;
            this.btnInicio.IsTab = true;
            this.btnInicio.Location = new System.Drawing.Point(3, 135);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Normalcolor = System.Drawing.Color.Transparent;
            this.btnInicio.OnHovercolor = System.Drawing.Color.Indigo;
            this.btnInicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInicio.selected = false;
            this.btnInicio.Size = new System.Drawing.Size(162, 43);
            this.btnInicio.TabIndex = 16;
            this.btnInicio.Text = "    INICIO";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Textcolor = System.Drawing.Color.White;
            this.btnInicio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Indigo;
            this.panel5.Location = new System.Drawing.Point(0, 135);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(6, 42);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Indigo;
            this.panel6.Location = new System.Drawing.Point(0, 181);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(6, 42);
            this.panel6.TabIndex = 17;
            // 
            // btnNomina
            // 
            this.btnNomina.Activecolor = System.Drawing.Color.Transparent;
            this.btnNomina.BackColor = System.Drawing.Color.Transparent;
            this.btnNomina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNomina.BorderRadius = 0;
            this.btnNomina.ButtonText = "     NOMINA";
            this.btnNomina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNomina.DisabledColor = System.Drawing.Color.Gray;
            this.btnNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNomina.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNomina.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNomina.Iconimage")));
            this.btnNomina.Iconimage_right = null;
            this.btnNomina.Iconimage_right_Selected = null;
            this.btnNomina.Iconimage_Selected = null;
            this.btnNomina.IconMarginLeft = 20;
            this.btnNomina.IconMarginRight = 0;
            this.btnNomina.IconRightVisible = true;
            this.btnNomina.IconRightZoom = 0D;
            this.btnNomina.IconVisible = true;
            this.btnNomina.IconZoom = 65D;
            this.btnNomina.IsTab = true;
            this.btnNomina.Location = new System.Drawing.Point(3, 181);
            this.btnNomina.Name = "btnNomina";
            this.btnNomina.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNomina.OnHovercolor = System.Drawing.Color.Indigo;
            this.btnNomina.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNomina.selected = false;
            this.btnNomina.Size = new System.Drawing.Size(162, 43);
            this.btnNomina.TabIndex = 18;
            this.btnNomina.Text = "     NOMINA";
            this.btnNomina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNomina.Textcolor = System.Drawing.Color.White;
            this.btnNomina.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNomina.Click += new System.EventHandler(this.btnNomina_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Location = new System.Drawing.Point(0, 227);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(6, 42);
            this.panel4.TabIndex = 19;
            // 
            // btnPersonas
            // 
            this.btnPersonas.Activecolor = System.Drawing.Color.Transparent;
            this.btnPersonas.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonas.BorderRadius = 0;
            this.btnPersonas.ButtonText = "    PERSONAS";
            this.btnPersonas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonas.DisabledColor = System.Drawing.Color.Gray;
            this.btnPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPersonas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPersonas.Iconimage")));
            this.btnPersonas.Iconimage_right = null;
            this.btnPersonas.Iconimage_right_Selected = null;
            this.btnPersonas.Iconimage_Selected = null;
            this.btnPersonas.IconMarginLeft = 20;
            this.btnPersonas.IconMarginRight = 0;
            this.btnPersonas.IconRightVisible = true;
            this.btnPersonas.IconRightZoom = 0D;
            this.btnPersonas.IconVisible = true;
            this.btnPersonas.IconZoom = 65D;
            this.btnPersonas.IsTab = true;
            this.btnPersonas.Location = new System.Drawing.Point(3, 227);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPersonas.OnHovercolor = System.Drawing.Color.Indigo;
            this.btnPersonas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPersonas.selected = false;
            this.btnPersonas.Size = new System.Drawing.Size(162, 43);
            this.btnPersonas.TabIndex = 20;
            this.btnPersonas.Text = "    PERSONAS";
            this.btnPersonas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonas.Textcolor = System.Drawing.Color.White;
            this.btnPersonas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonas.Click += new System.EventHandler(this.btnPersonas_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(0, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 42);
            this.panel2.TabIndex = 21;
            // 
            // btnReportes
            // 
            this.btnReportes.Activecolor = System.Drawing.Color.Transparent;
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportes.BorderRadius = 0;
            this.btnReportes.ButtonText = "    REPORTES";
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.DisabledColor = System.Drawing.Color.Gray;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReportes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReportes.Iconimage")));
            this.btnReportes.Iconimage_right = null;
            this.btnReportes.Iconimage_right_Selected = null;
            this.btnReportes.Iconimage_Selected = null;
            this.btnReportes.IconMarginLeft = 20;
            this.btnReportes.IconMarginRight = 0;
            this.btnReportes.IconRightVisible = true;
            this.btnReportes.IconRightZoom = 0D;
            this.btnReportes.IconVisible = true;
            this.btnReportes.IconZoom = 65D;
            this.btnReportes.IsTab = true;
            this.btnReportes.Location = new System.Drawing.Point(3, 273);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnReportes.OnHovercolor = System.Drawing.Color.Indigo;
            this.btnReportes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReportes.selected = false;
            this.btnReportes.Size = new System.Drawing.Size(162, 43);
            this.btnReportes.TabIndex = 22;
            this.btnReportes.Text = "    REPORTES";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Textcolor = System.Drawing.Color.White;
            this.btnReportes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(0, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 42);
            this.panel1.TabIndex = 23;
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Activecolor = System.Drawing.Color.Transparent;
            this.btnEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpresa.BorderRadius = 0;
            this.btnEmpresa.ButtonText = "    EMPRESA";
            this.btnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpresa.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmpresa.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEmpresa.Iconimage")));
            this.btnEmpresa.Iconimage_right = null;
            this.btnEmpresa.Iconimage_right_Selected = null;
            this.btnEmpresa.Iconimage_Selected = null;
            this.btnEmpresa.IconMarginLeft = 20;
            this.btnEmpresa.IconMarginRight = 0;
            this.btnEmpresa.IconRightVisible = true;
            this.btnEmpresa.IconRightZoom = 0D;
            this.btnEmpresa.IconVisible = true;
            this.btnEmpresa.IconZoom = 65D;
            this.btnEmpresa.IsTab = true;
            this.btnEmpresa.Location = new System.Drawing.Point(3, 319);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEmpresa.OnHovercolor = System.Drawing.Color.Indigo;
            this.btnEmpresa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmpresa.selected = false;
            this.btnEmpresa.Size = new System.Drawing.Size(162, 43);
            this.btnEmpresa.TabIndex = 24;
            this.btnEmpresa.Text = "    EMPRESA";
            this.btnEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpresa.Textcolor = System.Drawing.Color.White;
            this.btnEmpresa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(0, 365);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 42);
            this.panel3.TabIndex = 25;
            // 
            // btnAjustes
            // 
            this.btnAjustes.Activecolor = System.Drawing.Color.Transparent;
            this.btnAjustes.BackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjustes.BorderRadius = 0;
            this.btnAjustes.ButtonText = "    AJUSTES";
            this.btnAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjustes.DisabledColor = System.Drawing.Color.Gray;
            this.btnAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAjustes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAjustes.Iconimage")));
            this.btnAjustes.Iconimage_right = null;
            this.btnAjustes.Iconimage_right_Selected = null;
            this.btnAjustes.Iconimage_Selected = null;
            this.btnAjustes.IconMarginLeft = 20;
            this.btnAjustes.IconMarginRight = 0;
            this.btnAjustes.IconRightVisible = true;
            this.btnAjustes.IconRightZoom = 0D;
            this.btnAjustes.IconVisible = true;
            this.btnAjustes.IconZoom = 65D;
            this.btnAjustes.IsTab = true;
            this.btnAjustes.Location = new System.Drawing.Point(3, 365);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAjustes.OnHovercolor = System.Drawing.Color.Indigo;
            this.btnAjustes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAjustes.selected = false;
            this.btnAjustes.Size = new System.Drawing.Size(162, 43);
            this.btnAjustes.TabIndex = 26;
            this.btnAjustes.Text = "    AJUSTES";
            this.btnAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjustes.Textcolor = System.Drawing.Color.White;
            this.btnAjustes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // pictureBoxSalir
            // 
            this.pictureBoxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSalir.Image")));
            this.pictureBoxSalir.Location = new System.Drawing.Point(0, 474);
            this.pictureBoxSalir.Name = "pictureBoxSalir";
            this.pictureBoxSalir.Size = new System.Drawing.Size(33, 33);
            this.pictureBoxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSalir.TabIndex = 27;
            this.pictureBoxSalir.TabStop = false;
            this.pictureBoxSalir.Click += new System.EventHandler(this.pictureBoxSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 510);
            this.Controls.Add(this.pnlVista);
            this.Controls.Add(this.pnlApartados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlApartados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlApartados;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Panel pnlVista;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuFlatButton btnNomina;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuFlatButton btnInicio;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnReportes;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnPersonas;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnAjustes;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmpresa;
        private System.Windows.Forms.PictureBox pictureBoxSalir;
    }
}