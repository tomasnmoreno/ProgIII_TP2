namespace WinForm1
{
    partial class frmAgregarCategoria
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
            this.btnConfirmarNuevaCategoria = new System.Windows.Forms.Button();
            this.btnCancelarNuevaCategoria = new System.Windows.Forms.Button();
            this.lblNuevaCategoria = new System.Windows.Forms.Label();
            this.txtNuevaCategoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConfirmarNuevaCategoria
            // 
            this.btnConfirmarNuevaCategoria.Location = new System.Drawing.Point(111, 74);
            this.btnConfirmarNuevaCategoria.Name = "btnConfirmarNuevaCategoria";
            this.btnConfirmarNuevaCategoria.Size = new System.Drawing.Size(105, 34);
            this.btnConfirmarNuevaCategoria.TabIndex = 1;
            this.btnConfirmarNuevaCategoria.Text = "Confirmar";
            this.btnConfirmarNuevaCategoria.UseVisualStyleBackColor = true;
            this.btnConfirmarNuevaCategoria.Click += new System.EventHandler(this.btnConfirmarNuevaCategoria_Click);
            // 
            // btnCancelarNuevaCategoria
            // 
            this.btnCancelarNuevaCategoria.BackColor = System.Drawing.Color.Red;
            this.btnCancelarNuevaCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCancelarNuevaCategoria.Location = new System.Drawing.Point(235, 74);
            this.btnCancelarNuevaCategoria.Name = "btnCancelarNuevaCategoria";
            this.btnCancelarNuevaCategoria.Size = new System.Drawing.Size(105, 34);
            this.btnCancelarNuevaCategoria.TabIndex = 2;
            this.btnCancelarNuevaCategoria.Text = "Cancelar";
            this.btnCancelarNuevaCategoria.UseVisualStyleBackColor = false;
            this.btnCancelarNuevaCategoria.Click += new System.EventHandler(this.btnCancelarNuevaCategoria_Click);
            // 
            // lblNuevaCategoria
            // 
            this.lblNuevaCategoria.AutoSize = true;
            this.lblNuevaCategoria.Location = new System.Drawing.Point(108, 40);
            this.lblNuevaCategoria.Name = "lblNuevaCategoria";
            this.lblNuevaCategoria.Size = new System.Drawing.Size(69, 16);
            this.lblNuevaCategoria.TabIndex = 2;
            this.lblNuevaCategoria.Text = "Categoría:";
            // 
            // txtNuevaCategoria
            // 
            this.txtNuevaCategoria.Location = new System.Drawing.Point(183, 34);
            this.txtNuevaCategoria.Name = "txtNuevaCategoria";
            this.txtNuevaCategoria.Size = new System.Drawing.Size(157, 22);
            this.txtNuevaCategoria.TabIndex = 0;
            // 
            // frmAgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 147);
            this.Controls.Add(this.txtNuevaCategoria);
            this.Controls.Add(this.lblNuevaCategoria);
            this.Controls.Add(this.btnCancelarNuevaCategoria);
            this.Controls.Add(this.btnConfirmarNuevaCategoria);
            this.Name = "frmAgregarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Categoría";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmarNuevaCategoria;
        private System.Windows.Forms.Button btnCancelarNuevaCategoria;
        private System.Windows.Forms.Label lblNuevaCategoria;
        private System.Windows.Forms.TextBox txtNuevaCategoria;
    }
}