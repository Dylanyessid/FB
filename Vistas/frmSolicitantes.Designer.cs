
namespace FB.Vistas
{
    partial class frmSolicitantes
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
            this.btnDejarTrabajar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Red Hat Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "Posibles clientes";
            // 
            // btnDejarTrabajar
            // 
            this.btnDejarTrabajar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnDejarTrabajar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnDejarTrabajar.FlatAppearance.BorderSize = 0;
            this.btnDejarTrabajar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDejarTrabajar.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDejarTrabajar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDejarTrabajar.Location = new System.Drawing.Point(611, 79);
            this.btnDejarTrabajar.Name = "btnDejarTrabajar";
            this.btnDejarTrabajar.Size = new System.Drawing.Size(142, 63);
            this.btnDejarTrabajar.TabIndex = 43;
            this.btnDejarTrabajar.Text = "Dejar de Trabajar";
            this.btnDejarTrabajar.UseVisualStyleBackColor = false;
            this.btnDejarTrabajar.Click += new System.EventHandler(this.btnDejarTrabajar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(209, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 150);
            this.dataGridView1.TabIndex = 44;
            // 
            // frmSolicitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDejarTrabajar);
            this.Controls.Add(this.label1);
            this.Name = "frmSolicitantes";
            this.Text = "frmSolicitantes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDejarTrabajar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}