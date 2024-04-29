namespace WinForm1
{
    partial class frmCategorias
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
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnCategoriaSalir = new System.Windows.Forms.Button();
            this.lblListaCategorias = new System.Windows.Forms.Label();
            this.lblBuscarCategoria = new System.Windows.Forms.Label();
            this.txtFiltroCategorias = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategorias.Location = new System.Drawing.Point(49, 97);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(259, 259);
            this.dgvCategorias.TabIndex = 4;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(262, 97);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(84, 28);
            this.btnAgregarCategoria.TabIndex = 1;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Location = new System.Drawing.Point(262, 136);
            this.btnModificarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(84, 28);
            this.btnModificarCategoria.TabIndex = 2;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(262, 175);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(84, 28);
            this.btnEliminarCategoria.TabIndex = 3;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnCategoriaSalir
            // 
            this.btnCategoriaSalir.BackColor = System.Drawing.Color.Red;
            this.btnCategoriaSalir.ForeColor = System.Drawing.Color.White;
            this.btnCategoriaSalir.Location = new System.Drawing.Point(488, 304);
            this.btnCategoriaSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCategoriaSalir.Name = "btnCategoriaSalir";
            this.btnCategoriaSalir.Size = new System.Drawing.Size(84, 28);
            this.btnCategoriaSalir.TabIndex = 4;
            this.btnCategoriaSalir.Text = "Salir";
            this.btnCategoriaSalir.UseVisualStyleBackColor = false;
            this.btnCategoriaSalir.Click += new System.EventHandler(this.btnCategoriaSalir_Click);
            // 
            // lblListaCategorias
            // 
            this.lblListaCategorias.AutoSize = true;
            this.lblListaCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCategorias.Location = new System.Drawing.Point(44, 16);
            this.lblListaCategorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListaCategorias.Name = "lblListaCategorias";
            this.lblListaCategorias.Size = new System.Drawing.Size(213, 26);
            this.lblListaCategorias.TabIndex = 5;
            this.lblListaCategorias.Text = "Lista de categorías";
            // 
            // lblBuscarCategoria
            // 
            this.lblBuscarCategoria.AutoSize = true;
            this.lblBuscarCategoria.Location = new System.Drawing.Point(46, 72);
            this.lblBuscarCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarCategoria.Name = "lblBuscarCategoria";
            this.lblBuscarCategoria.Size = new System.Drawing.Size(58, 13);
            this.lblBuscarCategoria.TabIndex = 6;
            this.lblBuscarCategoria.Text = "Búsqueda:";
            // 
            // txtFiltroCategorias
            // 
            this.txtFiltroCategorias.Location = new System.Drawing.Point(105, 67);
            this.txtFiltroCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFiltroCategorias.Name = "txtFiltroCategorias";
            this.txtFiltroCategorias.Size = new System.Drawing.Size(108, 20);
            this.txtFiltroCategorias.TabIndex = 0;
            this.txtFiltroCategorias.TextChanged += new System.EventHandler(this.txtFiltroCategorias_TextChanged);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtFiltroCategorias);
            this.Controls.Add(this.lblBuscarCategoria);
            this.Controls.Add(this.lblListaCategorias);
            this.Controls.Add(this.btnCategoriaSalir);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.dgvCategorias);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorías";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnCategoriaSalir;
        private System.Windows.Forms.Label lblListaCategorias;
        private System.Windows.Forms.Label lblBuscarCategoria;
        private System.Windows.Forms.TextBox txtFiltroCategorias;
    }
}