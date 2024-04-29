namespace WinForm1
{
    partial class frmMarcas
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.lblTituloMarcas = new System.Windows.Forms.Label();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnMarcasSalir = new System.Windows.Forms.Button();
            this.lblBuscarMarca = new System.Windows.Forms.Label();
            this.txtFiltroMarcas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMarcas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.GridColor = System.Drawing.SystemColors.Control;
            this.dgvMarcas.Location = new System.Drawing.Point(57, 122);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.RowTemplate.Height = 24;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(257, 296);
            this.dgvMarcas.TabIndex = 0;
            // 
            // lblTituloMarcas
            // 
            this.lblTituloMarcas.AutoSize = true;
            this.lblTituloMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMarcas.Location = new System.Drawing.Point(58, 21);
            this.lblTituloMarcas.Name = "lblTituloMarcas";
            this.lblTituloMarcas.Size = new System.Drawing.Size(228, 32);
            this.lblTituloMarcas.TabIndex = 1;
            this.lblTituloMarcas.Text = "Lista de marcas";
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(339, 122);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(112, 35);
            this.btnAgregarMarca.TabIndex = 2;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Location = new System.Drawing.Point(339, 174);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(112, 35);
            this.btnModificarMarca.TabIndex = 3;
            this.btnModificarMarca.Text = "Modificar";
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            this.btnModificarMarca.Click += new System.EventHandler(this.btnModificarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(339, 226);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(112, 35);
            this.btnEliminarMarca.TabIndex = 4;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnMarcasSalir
            // 
            this.btnMarcasSalir.BackColor = System.Drawing.Color.Red;
            this.btnMarcasSalir.ForeColor = System.Drawing.Color.White;
            this.btnMarcasSalir.Location = new System.Drawing.Point(648, 392);
            this.btnMarcasSalir.Name = "btnMarcasSalir";
            this.btnMarcasSalir.Size = new System.Drawing.Size(112, 35);
            this.btnMarcasSalir.TabIndex = 5;
            this.btnMarcasSalir.Text = "Salir";
            this.btnMarcasSalir.UseVisualStyleBackColor = false;
            this.btnMarcasSalir.Click += new System.EventHandler(this.btnMarcasSalir_Click);
            // 
            // lblBuscarMarca
            // 
            this.lblBuscarMarca.AutoSize = true;
            this.lblBuscarMarca.Location = new System.Drawing.Point(64, 89);
            this.lblBuscarMarca.Name = "lblBuscarMarca";
            this.lblBuscarMarca.Size = new System.Drawing.Size(72, 16);
            this.lblBuscarMarca.TabIndex = 6;
            this.lblBuscarMarca.Text = "Búsqueda:";
            // 
            // txtFiltroMarcas
            // 
            this.txtFiltroMarcas.Location = new System.Drawing.Point(143, 82);
            this.txtFiltroMarcas.Name = "txtFiltroMarcas";
            this.txtFiltroMarcas.Size = new System.Drawing.Size(143, 22);
            this.txtFiltroMarcas.TabIndex = 7;
            this.txtFiltroMarcas.TextChanged += new System.EventHandler(this.txtFiltroMarcas_TextChanged);
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFiltroMarcas);
            this.Controls.Add(this.lblBuscarMarca);
            this.Controls.Add(this.btnMarcasSalir);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.lblTituloMarcas);
            this.Controls.Add(this.dgvMarcas);
            this.Name = "frmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.frmMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Label lblTituloMarcas;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnMarcasSalir;
        private System.Windows.Forms.Label lblBuscarMarca;
        private System.Windows.Forms.TextBox txtFiltroMarcas;
    }
}