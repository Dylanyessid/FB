
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
            this.SuspendLayout();
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lblIngreso.Font = new System.Drawing.Font("Red Hat Display Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.Location = new System.Drawing.Point(228, 32);
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
            this.label1.Location = new System.Drawing.Point(192, 132);
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
            this.btnPedirServicio.Location = new System.Drawing.Point(62, 187);
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
            this.btnOfrecerServicio.Location = new System.Drawing.Point(324, 187);
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
            this.button2.Location = new System.Drawing.Point(647, 77);
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOfrecerServicio);
            this.Controls.Add(this.btnPedirServicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIngreso);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
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
    }
}