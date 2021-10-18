
namespace FB.Vistas
{
    partial class frmCambiarUbicacion
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCambiarUbicacion = new System.Windows.Forms.Button();
            this.txtPais = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEstado = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCiudad = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRecogida = new MaterialSkin.Controls.MaterialTextBox();
            this.lblRecogida = new System.Windows.Forms.Label();
            this.txtDestino = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Red Hat Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(170, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 39);
            this.lblTitulo.TabIndex = 11;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.BackColor = System.Drawing.Color.Transparent;
            this.lblUbicacion.Font = new System.Drawing.Font("Red Hat Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(304, 63);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(182, 39);
            this.lblUbicacion.TabIndex = 12;
            this.lblUbicacion.Text = "UBICACION";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.Location = new System.Drawing.Point(587, 314);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(222, 75);
            this.btnConfirmar.TabIndex = 47;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCambiarUbicacion
            // 
            this.btnCambiarUbicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnCambiarUbicacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnCambiarUbicacion.FlatAppearance.BorderSize = 0;
            this.btnCambiarUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarUbicacion.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarUbicacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCambiarUbicacion.Location = new System.Drawing.Point(587, 227);
            this.btnCambiarUbicacion.Name = "btnCambiarUbicacion";
            this.btnCambiarUbicacion.Size = new System.Drawing.Size(222, 75);
            this.btnCambiarUbicacion.TabIndex = 48;
            this.btnCambiarUbicacion.Text = "Cambiar ubicacion";
            this.btnCambiarUbicacion.UseVisualStyleBackColor = false;
            // 
            // txtPais
            // 
            this.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPais.Depth = 0;
            this.txtPais.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPais.LeadingIcon = null;
            this.txtPais.Location = new System.Drawing.Point(33, 156);
            this.txtPais.MaxLength = 50;
            this.txtPais.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPais.Multiline = false;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(205, 50);
            this.txtPais.TabIndex = 49;
            this.txtPais.Text = "";
            this.txtPais.TrailingIcon = null;
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Depth = 0;
            this.txtEstado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEstado.LeadingIcon = null;
            this.txtEstado.Location = new System.Drawing.Point(281, 156);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEstado.Multiline = false;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(205, 50);
            this.txtEstado.TabIndex = 50;
            this.txtEstado.Text = "";
            this.txtEstado.TrailingIcon = null;
            // 
            // txtCiudad
            // 
            this.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCiudad.Depth = 0;
            this.txtCiudad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCiudad.LeadingIcon = null;
            this.txtCiudad.Location = new System.Drawing.Point(537, 156);
            this.txtCiudad.MaxLength = 50;
            this.txtCiudad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCiudad.Multiline = false;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(205, 50);
            this.txtCiudad.TabIndex = 51;
            this.txtCiudad.Text = "";
            this.txtCiudad.TrailingIcon = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 31);
            this.label3.TabIndex = 52;
            this.label3.Text = "Pais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 31);
            this.label4.TabIndex = 53;
            this.label4.Text = "Estado/Departamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(598, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 31);
            this.label5.TabIndex = 54;
            this.label5.Text = "Ciudad";
            // 
            // txtRecogida
            // 
            this.txtRecogida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecogida.Depth = 0;
            this.txtRecogida.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRecogida.LeadingIcon = null;
            this.txtRecogida.Location = new System.Drawing.Point(281, 252);
            this.txtRecogida.MaxLength = 50;
            this.txtRecogida.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRecogida.Multiline = false;
            this.txtRecogida.Name = "txtRecogida";
            this.txtRecogida.Size = new System.Drawing.Size(251, 50);
            this.txtRecogida.TabIndex = 55;
            this.txtRecogida.Text = "";
            this.txtRecogida.TrailingIcon = null;
            // 
            // lblRecogida
            // 
            this.lblRecogida.AutoSize = true;
            this.lblRecogida.BackColor = System.Drawing.Color.Transparent;
            this.lblRecogida.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecogida.Location = new System.Drawing.Point(12, 254);
            this.lblRecogida.Name = "lblRecogida";
            this.lblRecogida.Size = new System.Drawing.Size(261, 31);
            this.lblRecogida.TabIndex = 57;
            this.lblRecogida.Text = "Dirección de recogida";
            // 
            // txtDestino
            // 
            this.txtDestino.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDestino.Depth = 0;
            this.txtDestino.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDestino.LeadingIcon = null;
            this.txtDestino.Location = new System.Drawing.Point(281, 323);
            this.txtDestino.MaxLength = 50;
            this.txtDestino.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDestino.Multiline = false;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(251, 50);
            this.txtDestino.TabIndex = 58;
            this.txtDestino.Text = "";
            this.txtDestino.TrailingIcon = null;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblDestino.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(12, 335);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(247, 31);
            this.lblDestino.TabIndex = 59;
            this.lblDestino.Text = "Dirección de destino";
            // 
            // frmCambiarUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 444);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.lblRecogida);
            this.Controls.Add(this.txtRecogida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.btnCambiarUbicacion);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCambiarUbicacion";
            this.Text = "frmCambiarUbicacion";
            this.Load += new System.EventHandler(this.frmCambiarUbicacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCambiarUbicacion;
        private MaterialSkin.Controls.MaterialTextBox txtPais;
        private MaterialSkin.Controls.MaterialTextBox txtEstado;
        private MaterialSkin.Controls.MaterialTextBox txtCiudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox txtRecogida;
        private System.Windows.Forms.Label lblRecogida;
        private MaterialSkin.Controls.MaterialTextBox txtDestino;
        private System.Windows.Forms.Label lblDestino;
    }
}