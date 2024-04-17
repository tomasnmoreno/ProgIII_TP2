﻿namespace WinForm1
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
            this.TituloModulo = new System.Windows.Forms.Label();
            this.ListadoArticulos = new System.Windows.Forms.Button();
            this.BusquedaArticulos = new System.Windows.Forms.Button();
            this.AgregarArticulo = new System.Windows.Forms.Button();
            this.ModificarArticulo = new System.Windows.Forms.Button();
            this.EliminarArticulos = new System.Windows.Forms.Button();
            this.VerDetalleArticulos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TituloModulo
            // 
            this.TituloModulo.AutoSize = true;
            this.TituloModulo.BackColor = System.Drawing.SystemColors.Menu;
            this.TituloModulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TituloModulo.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloModulo.Location = new System.Drawing.Point(57, 33);
            this.TituloModulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloModulo.Name = "TituloModulo";
            this.TituloModulo.Size = new System.Drawing.Size(384, 50);
            this.TituloModulo.TabIndex = 6;
            this.TituloModulo.Text = "Maestro de Artículos";
            // 
            // ListadoArticulos
            // 
            this.ListadoArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListadoArticulos.Location = new System.Drawing.Point(57, 137);
            this.ListadoArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.ListadoArticulos.Name = "ListadoArticulos";
            this.ListadoArticulos.Size = new System.Drawing.Size(243, 28);
            this.ListadoArticulos.TabIndex = 7;
            this.ListadoArticulos.Text = "Listado de artículos";
            this.ListadoArticulos.UseVisualStyleBackColor = true;
            // 
            // BusquedaArticulos
            // 
            this.BusquedaArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BusquedaArticulos.Location = new System.Drawing.Point(57, 199);
            this.BusquedaArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.BusquedaArticulos.Name = "BusquedaArticulos";
            this.BusquedaArticulos.Size = new System.Drawing.Size(243, 28);
            this.BusquedaArticulos.TabIndex = 8;
            this.BusquedaArticulos.Text = "Búsqueda de Artículos";
            this.BusquedaArticulos.UseVisualStyleBackColor = true;
            this.BusquedaArticulos.Click += new System.EventHandler(this.BusquedaArticulos_Click);
            // 
            // AgregarArticulo
            // 
            this.AgregarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AgregarArticulo.Location = new System.Drawing.Point(57, 267);
            this.AgregarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.AgregarArticulo.Name = "AgregarArticulo";
            this.AgregarArticulo.Size = new System.Drawing.Size(243, 28);
            this.AgregarArticulo.TabIndex = 9;
            this.AgregarArticulo.Text = "Agregar Artículo";
            this.AgregarArticulo.UseVisualStyleBackColor = true;
            this.AgregarArticulo.Click += new System.EventHandler(this.AgregarArticulo_Click);
            // 
            // ModificarArticulo
            // 
            this.ModificarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ModificarArticulo.Location = new System.Drawing.Point(57, 330);
            this.ModificarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.ModificarArticulo.Name = "ModificarArticulo";
            this.ModificarArticulo.Size = new System.Drawing.Size(243, 28);
            this.ModificarArticulo.TabIndex = 10;
            this.ModificarArticulo.Text = "Modificar Artículo";
            this.ModificarArticulo.UseVisualStyleBackColor = true;
            this.ModificarArticulo.Click += new System.EventHandler(this.ModificarArticulo_Click);
            // 
            // EliminarArticulos
            // 
            this.EliminarArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EliminarArticulos.Location = new System.Drawing.Point(57, 390);
            this.EliminarArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarArticulos.Name = "EliminarArticulos";
            this.EliminarArticulos.Size = new System.Drawing.Size(243, 28);
            this.EliminarArticulos.TabIndex = 11;
            this.EliminarArticulos.Text = "Eliminar Artículos";
            this.EliminarArticulos.UseVisualStyleBackColor = true;
            // 
            // VerDetalleArticulos
            // 
            this.VerDetalleArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VerDetalleArticulos.Location = new System.Drawing.Point(57, 457);
            this.VerDetalleArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.VerDetalleArticulos.Name = "VerDetalleArticulos";
            this.VerDetalleArticulos.Size = new System.Drawing.Size(243, 28);
            this.VerDetalleArticulos.TabIndex = 12;
            this.VerDetalleArticulos.Text = "Ver Detalle de Artículos";
            this.VerDetalleArticulos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Marcas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 199);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Categorías";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VerDetalleArticulos);
            this.Controls.Add(this.EliminarArticulos);
            this.Controls.Add(this.ModificarArticulo);
            this.Controls.Add(this.AgregarArticulo);
            this.Controls.Add(this.BusquedaArticulos);
            this.Controls.Add(this.ListadoArticulos);
            this.Controls.Add(this.TituloModulo);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maestro de Artículos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TituloModulo;
        private System.Windows.Forms.Button ListadoArticulos;
        private System.Windows.Forms.Button BusquedaArticulos;
        private System.Windows.Forms.Button AgregarArticulo;
        private System.Windows.Forms.Button ModificarArticulo;
        private System.Windows.Forms.Button EliminarArticulos;
        private System.Windows.Forms.Button VerDetalleArticulos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}