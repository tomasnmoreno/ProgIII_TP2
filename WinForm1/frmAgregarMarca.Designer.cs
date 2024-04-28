namespace WinForm1
{
    partial class frmAgregarMarca
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
            this.lblNuevaMarca = new System.Windows.Forms.Label();
            this.txtNuevaMarca = new System.Windows.Forms.TextBox();
            this.btnConfirmarNuevaMarca = new System.Windows.Forms.Button();
            this.btnCancelarNuevaMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNuevaMarca
            // 
            this.lblNuevaMarca.AutoSize = true;
            this.lblNuevaMarca.Location = new System.Drawing.Point(115, 31);
            this.lblNuevaMarca.Name = "lblNuevaMarca";
            this.lblNuevaMarca.Size = new System.Drawing.Size(45, 16);
            this.lblNuevaMarca.TabIndex = 0;
            this.lblNuevaMarca.Text = "Marca";
            // 
            // txtNuevaMarca
            // 
            this.txtNuevaMarca.Location = new System.Drawing.Point(166, 25);
            this.txtNuevaMarca.Name = "txtNuevaMarca";
            this.txtNuevaMarca.Size = new System.Drawing.Size(162, 22);
            this.txtNuevaMarca.TabIndex = 0;
            // 
            // btnConfirmarNuevaMarca
            // 
            this.btnConfirmarNuevaMarca.Location = new System.Drawing.Point(127, 68);
            this.btnConfirmarNuevaMarca.Name = "btnConfirmarNuevaMarca";
            this.btnConfirmarNuevaMarca.Size = new System.Drawing.Size(94, 34);
            this.btnConfirmarNuevaMarca.TabIndex = 1;
            this.btnConfirmarNuevaMarca.Text = "Confirmar";
            this.btnConfirmarNuevaMarca.UseVisualStyleBackColor = true;
            this.btnConfirmarNuevaMarca.Click += new System.EventHandler(this.btnConfirmarNuevaMarca_Click);
            // 
            // btnCancelarNuevaMarca
            // 
            this.btnCancelarNuevaMarca.BackColor = System.Drawing.Color.Red;
            this.btnCancelarNuevaMarca.ForeColor = System.Drawing.Color.White;
            this.btnCancelarNuevaMarca.Location = new System.Drawing.Point(230, 68);
            this.btnCancelarNuevaMarca.Name = "btnCancelarNuevaMarca";
            this.btnCancelarNuevaMarca.Size = new System.Drawing.Size(94, 34);
            this.btnCancelarNuevaMarca.TabIndex = 2;
            this.btnCancelarNuevaMarca.Text = "Cancelar";
            this.btnCancelarNuevaMarca.UseVisualStyleBackColor = false;
            this.btnCancelarNuevaMarca.Click += new System.EventHandler(this.btnCancelarNuevaMarca_Click);
            // 
            // frmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 147);
            this.Controls.Add(this.btnCancelarNuevaMarca);
            this.Controls.Add(this.btnConfirmarNuevaMarca);
            this.Controls.Add(this.txtNuevaMarca);
            this.Controls.Add(this.lblNuevaMarca);
            this.Name = "frmAgregarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaMarca;
        private System.Windows.Forms.TextBox txtNuevaMarca;
        private System.Windows.Forms.Button btnConfirmarNuevaMarca;
        private System.Windows.Forms.Button btnCancelarNuevaMarca;
    }
}