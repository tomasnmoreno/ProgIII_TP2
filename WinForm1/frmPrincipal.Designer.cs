namespace WinForm1
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.lblMaestroArticulos = new System.Windows.Forms.Label();
            this.lblListado = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblCampoBusqueda = new System.Windows.Forms.Label();
            this.lblBusquedaCriterio = new System.Windows.Forms.Label();
            this.cboBusquedaCampo = new System.Windows.Forms.ComboBox();
            this.cboBusquedaCriterio = new System.Windows.Forms.ComboBox();
            this.lblFiltroBusqueda = new System.Windows.Forms.Label();
            this.txtFiltroBusqueda = new System.Windows.Forms.TextBox();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.lblBusquedaAvanzada = new System.Windows.Forms.Label();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 104);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(639, 225);
            this.dgvArticulos.TabIndex = 10;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // lblMaestroArticulos
            // 
            this.lblMaestroArticulos.AutoSize = true;
            this.lblMaestroArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaestroArticulos.Location = new System.Drawing.Point(12, 15);
            this.lblMaestroArticulos.Name = "lblMaestroArticulos";
            this.lblMaestroArticulos.Size = new System.Drawing.Size(301, 33);
            this.lblMaestroArticulos.TabIndex = 1;
            this.lblMaestroArticulos.Text = "Maestro de Articulos";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.Location = new System.Drawing.Point(14, 77);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(69, 24);
            this.lblListado.TabIndex = 2;
            this.lblListado.Text = "Listado";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(12, 352);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.Location = new System.Drawing.Point(671, 104);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(237, 225);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 4;
            this.pbxArticulo.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(110, 352);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 30);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(822, 430);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 30);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Location = new System.Drawing.Point(208, 352);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(85, 30);
            this.btnEliminarFisico.TabIndex = 3;
            this.btnEliminarFisico.Text = "Eliminar";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(438, 83);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(58, 13);
            this.lblBusqueda.TabIndex = 11;
            this.lblBusqueda.Text = "Búsqueda:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(496, 78);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(141, 20);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblCampoBusqueda
            // 
            this.lblCampoBusqueda.AutoSize = true;
            this.lblCampoBusqueda.Location = new System.Drawing.Point(10, 446);
            this.lblCampoBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCampoBusqueda.Name = "lblCampoBusqueda";
            this.lblCampoBusqueda.Size = new System.Drawing.Size(40, 13);
            this.lblCampoBusqueda.TabIndex = 13;
            this.lblCampoBusqueda.Text = "Campo";
            // 
            // lblBusquedaCriterio
            // 
            this.lblBusquedaCriterio.AutoSize = true;
            this.lblBusquedaCriterio.Location = new System.Drawing.Point(175, 447);
            this.lblBusquedaCriterio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusquedaCriterio.Name = "lblBusquedaCriterio";
            this.lblBusquedaCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblBusquedaCriterio.TabIndex = 14;
            this.lblBusquedaCriterio.Text = "Criterio";
            // 
            // cboBusquedaCampo
            // 
            this.cboBusquedaCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusquedaCampo.FormattingEnabled = true;
            this.cboBusquedaCampo.Location = new System.Drawing.Point(60, 440);
            this.cboBusquedaCampo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBusquedaCampo.Name = "cboBusquedaCampo";
            this.cboBusquedaCampo.Size = new System.Drawing.Size(104, 21);
            this.cboBusquedaCampo.TabIndex = 4;
            this.cboBusquedaCampo.SelectedIndexChanged += new System.EventHandler(this.cboBusquedaCampo_SelectedIndexChanged);
            // 
            // cboBusquedaCriterio
            // 
            this.cboBusquedaCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusquedaCriterio.FormattingEnabled = true;
            this.cboBusquedaCriterio.Location = new System.Drawing.Point(224, 440);
            this.cboBusquedaCriterio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBusquedaCriterio.Name = "cboBusquedaCriterio";
            this.cboBusquedaCriterio.Size = new System.Drawing.Size(104, 21);
            this.cboBusquedaCriterio.TabIndex = 5;
            // 
            // lblFiltroBusqueda
            // 
            this.lblFiltroBusqueda.AutoSize = true;
            this.lblFiltroBusqueda.Location = new System.Drawing.Point(338, 446);
            this.lblFiltroBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltroBusqueda.Name = "lblFiltroBusqueda";
            this.lblFiltroBusqueda.Size = new System.Drawing.Size(29, 13);
            this.lblFiltroBusqueda.TabIndex = 17;
            this.lblFiltroBusqueda.Text = "Filtro";
            // 
            // txtFiltroBusqueda
            // 
            this.txtFiltroBusqueda.Location = new System.Drawing.Point(377, 442);
            this.txtFiltroBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFiltroBusqueda.Name = "txtFiltroBusqueda";
            this.txtFiltroBusqueda.Size = new System.Drawing.Size(76, 20);
            this.txtFiltroBusqueda.TabIndex = 6;
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(469, 440);
            this.btnBusquedaAvanzada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(70, 23);
            this.btnBusquedaAvanzada.TabIndex = 7;
            this.btnBusquedaAvanzada.Text = "Buscar";
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.btnBusquedaAvanzada_Click);
            // 
            // lblBusquedaAvanzada
            // 
            this.lblBusquedaAvanzada.AutoSize = true;
            this.lblBusquedaAvanzada.Location = new System.Drawing.Point(10, 416);
            this.lblBusquedaAvanzada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusquedaAvanzada.Name = "lblBusquedaAvanzada";
            this.lblBusquedaAvanzada.Size = new System.Drawing.Size(106, 13);
            this.lblBusquedaAvanzada.TabIndex = 20;
            this.lblBusquedaAvanzada.Text = "Búsqueda Avanzada";
            // 
            // btnMarcas
            // 
            this.btnMarcas.Location = new System.Drawing.Point(416, 352);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(85, 30);
            this.btnMarcas.TabIndex = 21;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(514, 352);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(85, 30);
            this.btnCategorias.TabIndex = 22;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Location = new System.Drawing.Point(313, 352);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(85, 30);
            this.btnVerDetalle.TabIndex = 23;
            this.btnVerDetalle.Text = "VerDetalle";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(916, 491);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.lblBusquedaAvanzada);
            this.Controls.Add(this.btnBusquedaAvanzada);
            this.Controls.Add(this.txtFiltroBusqueda);
            this.Controls.Add(this.lblFiltroBusqueda);
            this.Controls.Add(this.cboBusquedaCriterio);
            this.Controls.Add(this.cboBusquedaCampo);
            this.Controls.Add(this.lblBusquedaCriterio);
            this.Controls.Add(this.lblCampoBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.lblMaestroArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.MinimumSize = new System.Drawing.Size(818, 495);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maestro de Articulos";
            this.Load += new System.EventHandler(this.frmPrincipal2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label lblMaestroArticulos;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblCampoBusqueda;
        private System.Windows.Forms.Label lblBusquedaCriterio;
        private System.Windows.Forms.ComboBox cboBusquedaCampo;
        private System.Windows.Forms.ComboBox cboBusquedaCriterio;
        private System.Windows.Forms.Label lblFiltroBusqueda;
        private System.Windows.Forms.TextBox txtFiltroBusqueda;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.Label lblBusquedaAvanzada;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnVerDetalle;
    }
}