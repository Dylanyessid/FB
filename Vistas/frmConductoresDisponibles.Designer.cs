
namespace FB
{
    partial class frmConductoresDisponibles
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOpciones = new MaterialSkin.Controls.MaterialComboBox();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPropuestaPrecio = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarConductores = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Red Hat Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "Conductores disponibles";
            // 
            // cmbOpciones
            // 
            this.cmbOpciones.AutoResize = false;
            this.cmbOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbOpciones.Depth = 0;
            this.cmbOpciones.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbOpciones.DropDownHeight = 174;
            this.cmbOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpciones.DropDownWidth = 121;
            this.cmbOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbOpciones.FormattingEnabled = true;
            this.cmbOpciones.IntegralHeight = false;
            this.cmbOpciones.ItemHeight = 43;
            this.cmbOpciones.Location = new System.Drawing.Point(306, 230);
            this.cmbOpciones.MaxDropDownItems = 4;
            this.cmbOpciones.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbOpciones.Name = "cmbOpciones";
            this.cmbOpciones.Size = new System.Drawing.Size(183, 49);
            this.cmbOpciones.StartIndex = 0;
            this.cmbOpciones.TabIndex = 9;
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.BackColor = System.Drawing.Color.Transparent;
            this.lblOpciones.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.Location = new System.Drawing.Point(139, 239);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(129, 31);
            this.lblOpciones.TabIndex = 10;
            this.lblOpciones.Text = "Opciones:";
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblPrimerNombre.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNombre.Location = new System.Drawing.Point(139, 305);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(185, 31);
            this.lblPrimerNombre.TabIndex = 11;
            this.lblPrimerNombre.Text = "PrimerNombre";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(354, 305);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(187, 31);
            this.lblPrimerApellido.TabIndex = 12;
            this.lblPrimerApellido.Text = "PrimerApellido";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(300, 336);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(87, 31);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaca.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(406, 382);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(135, 31);
            this.lblPlaca.TabIndex = 14;
            this.lblPlaca.Text = "PlacaMoto";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(238, 382);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(160, 31);
            this.lblModelo.TabIndex = 15;
            this.lblModelo.Text = "ModeloMoto";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(566, 382);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(77, 31);
            this.lblColor.TabIndex = 16;
            this.lblColor.Text = "Color";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(190, 430);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(330, 49);
            this.btnAceptar.TabIndex = 43;
            this.btnAceptar.Text = "Aceptar Conductor";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPropuestaPrecio
            // 
            this.txtPropuestaPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPropuestaPrecio.Depth = 0;
            this.txtPropuestaPrecio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPropuestaPrecio.Hint = "Precio";
            this.txtPropuestaPrecio.LeadingIcon = null;
            this.txtPropuestaPrecio.Location = new System.Drawing.Point(360, 69);
            this.txtPropuestaPrecio.MaxLength = 50;
            this.txtPropuestaPrecio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPropuestaPrecio.Multiline = false;
            this.txtPropuestaPrecio.Name = "txtPropuestaPrecio";
            this.txtPropuestaPrecio.Size = new System.Drawing.Size(173, 50);
            this.txtPropuestaPrecio.TabIndex = 44;
            this.txtPropuestaPrecio.Text = "";
            this.txtPropuestaPrecio.TrailingIcon = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 31);
            this.label3.TabIndex = 45;
            this.label3.Text = "Propuesta de precio:";
            // 
            // btnBuscarConductores
            // 
            this.btnBuscarConductores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnBuscarConductores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnBuscarConductores.FlatAppearance.BorderSize = 0;
            this.btnBuscarConductores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarConductores.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarConductores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarConductores.Location = new System.Drawing.Point(244, 125);
            this.btnBuscarConductores.Name = "btnBuscarConductores";
            this.btnBuscarConductores.Size = new System.Drawing.Size(240, 41);
            this.btnBuscarConductores.TabIndex = 46;
            this.btnBuscarConductores.Text = "Buscar Conductores";
            this.btnBuscarConductores.UseVisualStyleBackColor = false;
            this.btnBuscarConductores.Click += new System.EventHandler(this.btnBuscarConductores_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(76, 382);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(143, 31);
            this.lblMarca.TabIndex = 47;
            this.lblMarca.Text = "MarcaMoto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 31);
            this.label5.TabIndex = 48;
            this.label5.Text = "$";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(244, 172);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(240, 41);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar Petición";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmConductoresDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 491);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnBuscarConductores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPropuestaPrecio);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPrimerApellido);
            this.Controls.Add(this.lblPrimerNombre);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.cmbOpciones);
            this.Controls.Add(this.label1);
            this.Name = "frmConductoresDisponibles";
            this.Text = "txtPropuestaPrecio";
            this.Load += new System.EventHandler(this.frmConductoresDisponibles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox cmbOpciones;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnAceptar;
        private MaterialSkin.Controls.MaterialTextBox txtPropuestaPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarConductores;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
    }
}