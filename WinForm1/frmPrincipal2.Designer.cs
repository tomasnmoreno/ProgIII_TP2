namespace WinForm1
{
    partial class frmPrincipal2
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
            this.dgvArticulos.Location = new System.Drawing.Point(16, 128);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(852, 277);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // lblMaestroArticulos
            // 
            this.lblMaestroArticulos.AutoSize = true;
            this.lblMaestroArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaestroArticulos.Location = new System.Drawing.Point(16, 19);
            this.lblMaestroArticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaestroArticulos.Name = "lblMaestroArticulos";
            this.lblMaestroArticulos.Size = new System.Drawing.Size(378, 42);
            this.lblMaestroArticulos.TabIndex = 1;
            this.lblMaestroArticulos.Text = "Maestro de Articulos";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.Location = new System.Drawing.Point(19, 95);
            this.lblListado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(91, 29);
            this.lblListado.TabIndex = 2;
            this.lblListado.Text = "Listado";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(16, 433);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 37);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.Location = new System.Drawing.Point(895, 128);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(316, 277);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 4;
            this.pbxArticulo.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(144, 433);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 37);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1096, 529);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(113, 37);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Location = new System.Drawing.Point(272, 433);
            this.btnEliminarFisico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(113, 37);
            this.btnEliminarFisico.TabIndex = 10;
            this.btnEliminarFisico.Text = "Eliminar";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(584, 102);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(72, 16);
            this.lblBusqueda.TabIndex = 11;
            this.lblBusqueda.Text = "Búsqueda:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(662, 96);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(187, 22);
            this.txtBusqueda.TabIndex = 12;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblCampoBusqueda
            // 
            this.lblCampoBusqueda.AutoSize = true;
            this.lblCampoBusqueda.Location = new System.Drawing.Point(13, 549);
            this.lblCampoBusqueda.Name = "lblCampoBusqueda";
            this.lblCampoBusqueda.Size = new System.Drawing.Size(51, 16);
            this.lblCampoBusqueda.TabIndex = 13;
            this.lblCampoBusqueda.Text = "Campo";
            // 
            // lblBusquedaCriterio
            // 
            this.lblBusquedaCriterio.AutoSize = true;
            this.lblBusquedaCriterio.Location = new System.Drawing.Point(233, 550);
            this.lblBusquedaCriterio.Name = "lblBusquedaCriterio";
            this.lblBusquedaCriterio.Size = new System.Drawing.Size(49, 16);
            this.lblBusquedaCriterio.TabIndex = 14;
            this.lblBusquedaCriterio.Text = "Criterio";
            // 
            // cboBusquedaCampo
            // 
            this.cboBusquedaCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusquedaCampo.FormattingEnabled = true;
            this.cboBusquedaCampo.Location = new System.Drawing.Point(80, 542);
            this.cboBusquedaCampo.Name = "cboBusquedaCampo";
            this.cboBusquedaCampo.Size = new System.Drawing.Size(137, 24);
            this.cboBusquedaCampo.TabIndex = 15;
            this.cboBusquedaCampo.SelectedIndexChanged += new System.EventHandler(this.cboBusquedaCampo_SelectedIndexChanged);
            // 
            // cboBusquedaCriterio
            // 
            this.cboBusquedaCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusquedaCriterio.FormattingEnabled = true;
            this.cboBusquedaCriterio.Location = new System.Drawing.Point(298, 542);
            this.cboBusquedaCriterio.Name = "cboBusquedaCriterio";
            this.cboBusquedaCriterio.Size = new System.Drawing.Size(137, 24);
            this.cboBusquedaCriterio.TabIndex = 16;
            // 
            // lblFiltroBusqueda
            // 
            this.lblFiltroBusqueda.AutoSize = true;
            this.lblFiltroBusqueda.Location = new System.Drawing.Point(451, 549);
            this.lblFiltroBusqueda.Name = "lblFiltroBusqueda";
            this.lblFiltroBusqueda.Size = new System.Drawing.Size(36, 16);
            this.lblFiltroBusqueda.TabIndex = 17;
            this.lblFiltroBusqueda.Text = "Filtro";
            // 
            // txtFiltroBusqueda
            // 
            this.txtFiltroBusqueda.Location = new System.Drawing.Point(503, 544);
            this.txtFiltroBusqueda.Name = "txtFiltroBusqueda";
            this.txtFiltroBusqueda.Size = new System.Drawing.Size(100, 22);
            this.txtFiltroBusqueda.TabIndex = 18;
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(625, 542);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(93, 28);
            this.btnBusquedaAvanzada.TabIndex = 19;
            this.btnBusquedaAvanzada.Text = "Buscar";
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.btnBusquedaAvanzada_Click);
            // 
            // lblBusquedaAvanzada
            // 
            this.lblBusquedaAvanzada.AutoSize = true;
            this.lblBusquedaAvanzada.Location = new System.Drawing.Point(13, 512);
            this.lblBusquedaAvanzada.Name = "lblBusquedaAvanzada";
            this.lblBusquedaAvanzada.Size = new System.Drawing.Size(133, 16);
            this.lblBusquedaAvanzada.TabIndex = 20;
            this.lblBusquedaAvanzada.Text = "Búsqueda Avanzada";
            // 
            // frmPrincipal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1221, 604);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1085, 600);
            this.Name = "frmPrincipal2";
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
    }
}