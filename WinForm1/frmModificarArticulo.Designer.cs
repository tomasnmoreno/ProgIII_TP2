﻿namespace WinForm1
{
    partial class frmModificarArticulo
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.btnCancelarBusqueda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(56, 64);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(94, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código de artículo";
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Location = new System.Drawing.Point(154, 57);
            this.txtCodigoArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(76, 20);
            this.txtCodigoArticulo.TabIndex = 2;
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Location = new System.Drawing.Point(253, 53);
            this.btnBuscarArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(100, 26);
            this.btnBuscarArticulo.TabIndex = 3;
            this.btnBuscarArticulo.Text = "Buscar Artículo";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnCancelarBusqueda
            // 
            this.btnCancelarBusqueda.Location = new System.Drawing.Point(504, 306);
            this.btnCancelarBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarBusqueda.Name = "btnCancelarBusqueda";
            this.btnCancelarBusqueda.Size = new System.Drawing.Size(70, 37);
            this.btnCancelarBusqueda.TabIndex = 4;
            this.btnCancelarBusqueda.Text = "Cancelar";
            this.btnCancelarBusqueda.UseVisualStyleBackColor = true;
            // 
            // frmModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCancelarBusqueda);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.txtCodigoArticulo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmModificarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación de Articulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Button btnCancelarBusqueda;
    }
}