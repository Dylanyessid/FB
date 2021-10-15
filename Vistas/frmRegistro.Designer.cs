
namespace FB
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSegundoNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoHombre = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoMujer = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtPrimerApellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSegundoApellido = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDocumentoIdentidad = new MaterialSkin.Controls.MaterialTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCelular = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.txtPais = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEstado = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCuidad = new MaterialSkin.Controls.MaterialTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Primer Nombe";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrimerNombre.Depth = 0;
            this.txtPrimerNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrimerNombre.LeadingIcon = null;
            this.txtPrimerNombre.Location = new System.Drawing.Point(41, 136);
            this.txtPrimerNombre.MaxLength = 50;
            this.txtPrimerNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrimerNombre.Multiline = false;
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(225, 50);
            this.txtPrimerNombre.TabIndex = 9;
            this.txtPrimerNombre.Text = "";
            this.txtPrimerNombre.TrailingIcon = null;
            this.txtPrimerNombre.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Segundo Nombre";
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegundoNombre.Depth = 0;
            this.txtSegundoNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSegundoNombre.LeadingIcon = null;
            this.txtSegundoNombre.Location = new System.Drawing.Point(325, 144);
            this.txtSegundoNombre.MaxLength = 50;
            this.txtSegundoNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSegundoNombre.Multiline = false;
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(225, 50);
            this.txtSegundoNombre.TabIndex = 11;
            this.txtSegundoNombre.Text = "";
            this.txtSegundoNombre.TrailingIcon = null;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarFont = new System.Drawing.Font("Red Hat Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(66, 354);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(196, 20);
            this.dtpFechaNacimiento.TabIndex = 12;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // rdoHombre
            // 
            this.rdoHombre.AutoSize = true;
            this.rdoHombre.Depth = 0;
            this.rdoHombre.Location = new System.Drawing.Point(342, 354);
            this.rdoHombre.Margin = new System.Windows.Forms.Padding(0);
            this.rdoHombre.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoHombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoHombre.Name = "rdoHombre";
            this.rdoHombre.Ripple = true;
            this.rdoHombre.Size = new System.Drawing.Size(91, 37);
            this.rdoHombre.TabIndex = 14;
            this.rdoHombre.TabStop = true;
            this.rdoHombre.Text = "Hombre";
            this.rdoHombre.UseVisualStyleBackColor = true;
            // 
            // rdoMujer
            // 
            this.rdoMujer.AutoSize = true;
            this.rdoMujer.Depth = 0;
            this.rdoMujer.Location = new System.Drawing.Point(445, 354);
            this.rdoMujer.Margin = new System.Windows.Forms.Padding(0);
            this.rdoMujer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoMujer.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoMujer.Name = "rdoMujer";
            this.rdoMujer.Ripple = true;
            this.rdoMujer.Size = new System.Drawing.Size(75, 37);
            this.rdoMujer.TabIndex = 15;
            this.rdoMujer.TabStop = true;
            this.rdoMujer.Text = "Mujer";
            this.rdoMujer.UseVisualStyleBackColor = true;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrimerApellido.Depth = 0;
            this.txtPrimerApellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrimerApellido.LeadingIcon = null;
            this.txtPrimerApellido.Location = new System.Drawing.Point(41, 249);
            this.txtPrimerApellido.MaxLength = 50;
            this.txtPrimerApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrimerApellido.Multiline = false;
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(225, 50);
            this.txtPrimerApellido.TabIndex = 16;
            this.txtPrimerApellido.Text = "";
            this.txtPrimerApellido.TrailingIcon = null;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegundoApellido.Depth = 0;
            this.txtSegundoApellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSegundoApellido.LeadingIcon = null;
            this.txtSegundoApellido.Location = new System.Drawing.Point(325, 249);
            this.txtSegundoApellido.MaxLength = 50;
            this.txtSegundoApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSegundoApellido.Multiline = false;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(225, 50);
            this.txtSegundoApellido.TabIndex = 17;
            this.txtSegundoApellido.Text = "";
            this.txtSegundoApellido.TrailingIcon = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "Primer Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 31);
            this.label5.TabIndex = 19;
            this.label5.Text = "Segundo Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(336, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 62);
            this.label7.TabIndex = 21;
            this.label7.Text = "Documento \r\nde Identidad";
            // 
            // txtDocumentoIdentidad
            // 
            this.txtDocumentoIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumentoIdentidad.Depth = 0;
            this.txtDocumentoIdentidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDocumentoIdentidad.LeadingIcon = null;
            this.txtDocumentoIdentidad.Location = new System.Drawing.Point(37, 451);
            this.txtDocumentoIdentidad.MaxLength = 50;
            this.txtDocumentoIdentidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDocumentoIdentidad.Multiline = false;
            this.txtDocumentoIdentidad.Name = "txtDocumentoIdentidad";
            this.txtDocumentoIdentidad.Size = new System.Drawing.Size(225, 50);
            this.txtDocumentoIdentidad.TabIndex = 22;
            this.txtDocumentoIdentidad.Text = "";
            this.txtDocumentoIdentidad.TrailingIcon = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(343, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 31);
            this.label8.TabIndex = 23;
            this.label8.Text = "Número de celular";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCelular.Depth = 0;
            this.txtCelular.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCelular.LeadingIcon = null;
            this.txtCelular.Location = new System.Drawing.Point(349, 451);
            this.txtCelular.MaxLength = 50;
            this.txtCelular.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCelular.Multiline = false;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(225, 50);
            this.txtCelular.TabIndex = 24;
            this.txtCelular.Text = "";
            this.txtCelular.TrailingIcon = null;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSiguiente.Location = new System.Drawing.Point(349, 516);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(165, 52);
            this.btnSiguiente.TabIndex = 27;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // txtPais
            // 
            this.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPais.Depth = 0;
            this.txtPais.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPais.LeadingIcon = null;
            this.txtPais.Location = new System.Drawing.Point(651, 144);
            this.txtPais.MaxLength = 50;
            this.txtPais.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPais.Multiline = false;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(150, 50);
            this.txtPais.TabIndex = 28;
            this.txtPais.Text = "";
            this.txtPais.TrailingIcon = null;
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Depth = 0;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEstado.LeadingIcon = null;
            this.txtEstado.Location = new System.Drawing.Point(651, 263);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEstado.Multiline = false;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(165, 50);
            this.txtEstado.TabIndex = 29;
            this.txtEstado.Text = "";
            this.txtEstado.TrailingIcon = null;
            // 
            // txtCuidad
            // 
            this.txtCuidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuidad.Depth = 0;
            this.txtCuidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCuidad.LeadingIcon = null;
            this.txtCuidad.Location = new System.Drawing.Point(651, 394);
            this.txtCuidad.MaxLength = 50;
            this.txtCuidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCuidad.Multiline = false;
            this.txtCuidad.Name = "txtCuidad";
            this.txtCuidad.Size = new System.Drawing.Size(165, 50);
            this.txtCuidad.TabIndex = 30;
            this.txtCuidad.Text = "";
            this.txtCuidad.TrailingIcon = null;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(698, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 31);
            this.label9.TabIndex = 31;
            this.label9.Text = "Pais";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(686, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 31);
            this.label10.TabIndex = 32;
            this.label10.Text = "Estado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(686, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 31);
            this.label11.TabIndex = 33;
            this.label11.Text = "Ciudad";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(604, 113);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(13, 388);
            this.materialDivider1.TabIndex = 34;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(848, 580);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCuidad);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDocumentoIdentidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.rdoMujer);
            this.Controls.Add(this.rdoHombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmRegistro";
            this.Text = "6";
            this.Load += new System.EventHandler(this.frmRegistrocs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtPrimerNombre;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox txtSegundoNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialRadioButton rdoHombre;
        private MaterialSkin.Controls.MaterialRadioButton rdoMujer;
        private MaterialSkin.Controls.MaterialTextBox txtPrimerApellido;
        private MaterialSkin.Controls.MaterialTextBox txtSegundoApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialTextBox txtDocumentoIdentidad;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialTextBox txtCelular;
        private System.Windows.Forms.Button btnSiguiente;
        private MaterialSkin.Controls.MaterialTextBox txtPais;
        private MaterialSkin.Controls.MaterialTextBox txtEstado;
        private MaterialSkin.Controls.MaterialTextBox txtCuidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}