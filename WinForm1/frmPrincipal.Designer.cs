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
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TituloModulo
            // 
            this.TituloModulo.AutoSize = true;
            this.TituloModulo.BackColor = System.Drawing.SystemColors.Menu;
            this.TituloModulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TituloModulo.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloModulo.Location = new System.Drawing.Point(43, 27);
            this.TituloModulo.Name = "TituloModulo";
            this.TituloModulo.Size = new System.Drawing.Size(305, 39);
            this.TituloModulo.TabIndex = 6;
            this.TituloModulo.Text = "Maestro de Artículos";
            // 
            // ListadoArticulos
            // 
            this.ListadoArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListadoArticulos.Location = new System.Drawing.Point(43, 111);
            this.ListadoArticulos.Name = "ListadoArticulos";
            this.ListadoArticulos.Size = new System.Drawing.Size(182, 23);
            this.ListadoArticulos.TabIndex = 7;
            this.ListadoArticulos.Text = "Listado de artículos";
            this.ListadoArticulos.UseVisualStyleBackColor = true;
            // 
            // BusquedaArticulos
            // 
            this.BusquedaArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BusquedaArticulos.Location = new System.Drawing.Point(43, 162);
            this.BusquedaArticulos.Name = "BusquedaArticulos";
            this.BusquedaArticulos.Size = new System.Drawing.Size(182, 23);
            this.BusquedaArticulos.TabIndex = 8;
            this.BusquedaArticulos.Text = "Búsqueda de Artículos";
            this.BusquedaArticulos.UseVisualStyleBackColor = true;
            this.BusquedaArticulos.Click += new System.EventHandler(this.BusquedaArticulos_Click);
            // 
            // AgregarArticulo
            // 
            this.AgregarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AgregarArticulo.Location = new System.Drawing.Point(43, 217);
            this.AgregarArticulo.Name = "AgregarArticulo";
            this.AgregarArticulo.Size = new System.Drawing.Size(182, 23);
            this.AgregarArticulo.TabIndex = 9;
            this.AgregarArticulo.Text = "Agregar Artículo";
            this.AgregarArticulo.UseVisualStyleBackColor = true;
            this.AgregarArticulo.Click += new System.EventHandler(this.AgregarArticulo_Click);
            // 
            // ModificarArticulo
            // 
            this.ModificarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ModificarArticulo.Location = new System.Drawing.Point(43, 268);
            this.ModificarArticulo.Name = "ModificarArticulo";
            this.ModificarArticulo.Size = new System.Drawing.Size(182, 23);
            this.ModificarArticulo.TabIndex = 10;
            this.ModificarArticulo.Text = "Modificar Artículo";
            this.ModificarArticulo.UseVisualStyleBackColor = true;
            this.ModificarArticulo.Click += new System.EventHandler(this.ModificarArticulo_Click);
            // 
            // EliminarArticulos
            // 
            this.EliminarArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EliminarArticulos.Location = new System.Drawing.Point(43, 317);
            this.EliminarArticulos.Name = "EliminarArticulos";
            this.EliminarArticulos.Size = new System.Drawing.Size(182, 23);
            this.EliminarArticulos.TabIndex = 11;
            this.EliminarArticulos.Text = "Eliminar Artículos";
            this.EliminarArticulos.UseVisualStyleBackColor = true;
            // 
            // VerDetalleArticulos
            // 
            this.VerDetalleArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VerDetalleArticulos.Location = new System.Drawing.Point(43, 371);
            this.VerDetalleArticulos.Name = "VerDetalleArticulos";
            this.VerDetalleArticulos.Size = new System.Drawing.Size(182, 23);
            this.VerDetalleArticulos.TabIndex = 12;
            this.VerDetalleArticulos.Text = "Ver Detalle de Artículos";
            this.VerDetalleArticulos.UseVisualStyleBackColor = true;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(485, 121);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(42, 13);
            this.lblMarca.TabIndex = 13;
            this.lblMarca.Text = "Marcas";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(485, 167);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblCategoria.TabIndex = 14;
            this.lblCategoria.Text = "Categorias";
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(561, 120);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 15;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(561, 162);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 16;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
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
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
    }
}