
namespace FB.Vistas
{
    partial class frmPrincipal
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
            this.lblIngreso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPedirServicio = new System.Windows.Forms.Button();
            this.btnOfrecerServicio = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabOpcionesCuenta = new System.Windows.Forms.TabPage();
            this.tabMetodosPago = new System.Windows.Forms.TabPage();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnEliminarMetodoPago = new System.Windows.Forms.Button();
            this.btnEditarMetodoPago = new System.Windows.Forms.Button();
            this.cmbMetodosPago = new System.Windows.Forms.ComboBox();
            this.btnAgregatMetodoPago = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linklblAutor = new System.Windows.Forms.LinkLabel();
            this.linklblRepositorio = new System.Windows.Forms.LinkLabel();
            this.tabPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabMetodosPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lblIngreso.Font = new System.Drawing.Font("Red Hat Display Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.Location = new System.Drawing.Point(232, 3);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(210, 85);
            this.lblIngreso.TabIndex = 7;
            this.lblIngreso.Text = "Menú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Red Hat Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "¿Qué deseas hacer?";
            // 
            // btnPedirServicio
            // 
            this.btnPedirServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnPedirServicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnPedirServicio.FlatAppearance.BorderSize = 0;
            this.btnPedirServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedirServicio.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedirServicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPedirServicio.Location = new System.Drawing.Point(99, 174);
            this.btnPedirServicio.Name = "btnPedirServicio";
            this.btnPedirServicio.Size = new System.Drawing.Size(222, 75);
            this.btnPedirServicio.TabIndex = 48;
            this.btnPedirServicio.Text = "Quiero pedir un servicio";
            this.btnPedirServicio.UseVisualStyleBackColor = false;
            this.btnPedirServicio.Click += new System.EventHandler(this.btnPedirServicio_Click);
            // 
            // btnOfrecerServicio
            // 
            this.btnOfrecerServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnOfrecerServicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnOfrecerServicio.FlatAppearance.BorderSize = 0;
            this.btnOfrecerServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfrecerServicio.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfrecerServicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOfrecerServicio.Location = new System.Drawing.Point(327, 174);
            this.btnOfrecerServicio.Name = "btnOfrecerServicio";
            this.btnOfrecerServicio.Size = new System.Drawing.Size(222, 75);
            this.btnOfrecerServicio.TabIndex = 49;
            this.btnOfrecerServicio.Text = "Quiero ofrecer el servicio";
            this.btnOfrecerServicio.UseVisualStyleBackColor = false;
            this.btnOfrecerServicio.Click += new System.EventHandler(this.btnOfrecerServicio_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(609, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 75);
            this.button2.TabIndex = 50;
            this.button2.Text = "Cerrar Sesión";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Red Hat Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(531, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 35);
            this.lblNombre.TabIndex = 51;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPage1);
            this.tabPrincipal.Controls.Add(this.tabOpcionesCuenta);
            this.tabPrincipal.Controls.Add(this.tabMetodosPago);
            this.tabPrincipal.Controls.Add(this.tabPage2);
            this.tabPrincipal.Location = new System.Drawing.Point(12, 4);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(798, 373);
            this.tabPrincipal.TabIndex = 52;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblIngreso);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnPedirServicio);
            this.tabPage1.Controls.Add(this.btnOfrecerServicio);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Menú ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabOpcionesCuenta
            // 
            this.tabOpcionesCuenta.Location = new System.Drawing.Point(4, 22);
            this.tabOpcionesCuenta.Name = "tabOpcionesCuenta";
            this.tabOpcionesCuenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabOpcionesCuenta.Size = new System.Drawing.Size(790, 347);
            this.tabOpcionesCuenta.TabIndex = 1;
            this.tabOpcionesCuenta.Text = "Opciones de Cuenta";
            this.tabOpcionesCuenta.UseVisualStyleBackColor = true;
            // 
            // tabMetodosPago
            // 
            this.tabMetodosPago.AutoScroll = true;
            this.tabMetodosPago.Controls.Add(this.lblAviso);
            this.tabMetodosPago.Controls.Add(this.btnEliminarMetodoPago);
            this.tabMetodosPago.Controls.Add(this.btnEditarMetodoPago);
            this.tabMetodosPago.Controls.Add(this.cmbMetodosPago);
            this.tabMetodosPago.Controls.Add(this.btnAgregatMetodoPago);
            this.tabMetodosPago.Controls.Add(this.label2);
            this.tabMetodosPago.Location = new System.Drawing.Point(4, 22);
            this.tabMetodosPago.Name = "tabMetodosPago";
            this.tabMetodosPago.Padding = new System.Windows.Forms.Padding(3);
            this.tabMetodosPago.Size = new System.Drawing.Size(790, 347);
            this.tabMetodosPago.TabIndex = 2;
            this.tabMetodosPago.Text = "Métodos de Pago";
            this.tabMetodosPago.UseVisualStyleBackColor = true;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.Transparent;
            this.lblAviso.Font = new System.Drawing.Font("Red Hat Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.Location = new System.Drawing.Point(128, 122);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(548, 94);
            this.lblAviso.TabIndex = 55;
            this.lblAviso.Text = "No tienes actualmente ningún \r\nmétodo de pago agregado.\r\n";
            // 
            // btnEliminarMetodoPago
            // 
            this.btnEliminarMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnEliminarMetodoPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnEliminarMetodoPago.FlatAppearance.BorderSize = 0;
            this.btnEliminarMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMetodoPago.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMetodoPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarMetodoPago.Location = new System.Drawing.Point(511, 235);
            this.btnEliminarMetodoPago.Name = "btnEliminarMetodoPago";
            this.btnEliminarMetodoPago.Size = new System.Drawing.Size(198, 96);
            this.btnEliminarMetodoPago.TabIndex = 54;
            this.btnEliminarMetodoPago.Text = "Eliminar Método de Pago Seleccionado";
            this.btnEliminarMetodoPago.UseVisualStyleBackColor = false;
            // 
            // btnEditarMetodoPago
            // 
            this.btnEditarMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnEditarMetodoPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnEditarMetodoPago.FlatAppearance.BorderSize = 0;
            this.btnEditarMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarMetodoPago.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMetodoPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarMetodoPago.Location = new System.Drawing.Point(307, 235);
            this.btnEditarMetodoPago.Name = "btnEditarMetodoPago";
            this.btnEditarMetodoPago.Size = new System.Drawing.Size(198, 96);
            this.btnEditarMetodoPago.TabIndex = 53;
            this.btnEditarMetodoPago.Text = "Editar Método de Pago Seleccionado";
            this.btnEditarMetodoPago.UseVisualStyleBackColor = false;
            // 
            // cmbMetodosPago
            // 
            this.cmbMetodosPago.DropDownHeight = 120;
            this.cmbMetodosPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodosPago.FormattingEnabled = true;
            this.cmbMetodosPago.IntegralHeight = false;
            this.cmbMetodosPago.ItemHeight = 13;
            this.cmbMetodosPago.Location = new System.Drawing.Point(236, 98);
            this.cmbMetodosPago.Name = "cmbMetodosPago";
            this.cmbMetodosPago.Size = new System.Drawing.Size(336, 21);
            this.cmbMetodosPago.Sorted = true;
            this.cmbMetodosPago.TabIndex = 52;
            this.cmbMetodosPago.SelectedIndexChanged += new System.EventHandler(this.cmbMetodosPago_SelectedIndexChanged);
            // 
            // btnAgregatMetodoPago
            // 
            this.btnAgregatMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnAgregatMetodoPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnAgregatMetodoPago.FlatAppearance.BorderSize = 0;
            this.btnAgregatMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregatMetodoPago.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregatMetodoPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregatMetodoPago.Location = new System.Drawing.Point(111, 235);
            this.btnAgregatMetodoPago.Name = "btnAgregatMetodoPago";
            this.btnAgregatMetodoPago.Size = new System.Drawing.Size(190, 96);
            this.btnAgregatMetodoPago.TabIndex = 51;
            this.btnAgregatMetodoPago.Text = "Agregar Método de Pago";
            this.btnAgregatMetodoPago.UseVisualStyleBackColor = false;
            this.btnAgregatMetodoPago.Click += new System.EventHandler(this.btnAgregatMetodoPago_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Red Hat Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 64);
            this.label2.TabIndex = 8;
            this.label2.Text = "Métodos de Pago";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 347);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Historial de Viajes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 31);
            this.label3.TabIndex = 51;
            this.label3.Text = "Créditos a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 31);
            this.label4.TabIndex = 53;
            this.label4.Text = "JSON Localidades:";
            // 
            // linklblAutor
            // 
            this.linklblAutor.AutoSize = true;
            this.linklblAutor.Font = new System.Drawing.Font("Red Hat Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblAutor.Location = new System.Drawing.Point(163, 380);
            this.linklblAutor.Name = "linklblAutor";
            this.linklblAutor.Size = new System.Drawing.Size(132, 31);
            this.linklblAutor.TabIndex = 54;
            this.linklblAutor.TabStop = true;
            this.linklblAutor.Text = "millan2993";
            this.linklblAutor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblAutor_LinkClicked);
            // 
            // linklblRepositorio
            // 
            this.linklblRepositorio.AutoSize = true;
            this.linklblRepositorio.Font = new System.Drawing.Font("Red Hat Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblRepositorio.Location = new System.Drawing.Point(550, 380);
            this.linklblRepositorio.Name = "linklblRepositorio";
            this.linklblRepositorio.Size = new System.Drawing.Size(240, 31);
            this.linklblRepositorio.TabIndex = 55;
            this.linklblRepositorio.TabStop = true;
            this.linklblRepositorio.Text = "Repositorio (GitHub)";
            this.linklblRepositorio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblRepositorio_LinkClicked);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 414);
            this.Controls.Add(this.linklblRepositorio);
            this.Controls.Add(this.linklblAutor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabMetodosPago.ResumeLayout(false);
            this.tabMetodosPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPedirServicio;
        private System.Windows.Forms.Button btnOfrecerServicio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabOpcionesCuenta;
        private System.Windows.Forms.TabPage tabMetodosPago;
        private System.Windows.Forms.Button btnAgregatMetodoPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMetodosPago;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnEliminarMetodoPago;
        private System.Windows.Forms.Button btnEditarMetodoPago;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linklblAutor;
        private System.Windows.Forms.LinkLabel linklblRepositorio;
    }
}