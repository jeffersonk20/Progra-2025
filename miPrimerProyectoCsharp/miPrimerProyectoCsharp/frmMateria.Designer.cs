namespace miPrimerProyectoCsharp
{
    partial class frmMateria
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
            this.grbNavegacionMateria = new System.Windows.Forms.GroupBox();
            this.lblRegistrosMateria = new System.Windows.Forms.Label();
            this.btnUltimoMateria = new System.Windows.Forms.Button();
            this.btnSiguienteMateria = new System.Windows.Forms.Button();
            this.btnAnteriorMateria = new System.Windows.Forms.Button();
            this.btnPrimeroMateria = new System.Windows.Forms.Button();
            this.grbEdicionMateria = new System.Windows.Forms.GroupBox();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.grbBusquedaMateria = new System.Windows.Forms.GroupBox();
            this.cboBuscarMaterias = new System.Windows.Forms.ComboBox();
            this.grdMateria = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarMateria = new System.Windows.Forms.TextBox();
            this.grbDatosMateria = new System.Windows.Forms.GroupBox();
            this.idMateria = new System.Windows.Forms.Label();
            this.lblUvMateria = new System.Windows.Forms.Label();
            this.txtUvMateria = new System.Windows.Forms.TextBox();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.lblCodigoMateria = new System.Windows.Forms.Label();
            this.txtCodigoMateria = new System.Windows.Forms.TextBox();
            this.lblIdMateria = new System.Windows.Forms.Label();
            this.grbNavegacionMateria.SuspendLayout();
            this.grbEdicionMateria.SuspendLayout();
            this.grbBusquedaMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMateria)).BeginInit();
            this.grbDatosMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNavegacionMateria
            // 
            this.grbNavegacionMateria.Controls.Add(this.lblRegistrosMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnUltimoMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnSiguienteMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnAnteriorMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnPrimeroMateria);
            this.grbNavegacionMateria.Location = new System.Drawing.Point(35, 373);
            this.grbNavegacionMateria.Margin = new System.Windows.Forms.Padding(4);
            this.grbNavegacionMateria.Name = "grbNavegacionMateria";
            this.grbNavegacionMateria.Padding = new System.Windows.Forms.Padding(4);
            this.grbNavegacionMateria.Size = new System.Drawing.Size(297, 72);
            this.grbNavegacionMateria.TabIndex = 8;
            this.grbNavegacionMateria.TabStop = false;
            this.grbNavegacionMateria.Text = "Navegacion";
            // 
            // lblRegistrosMateria
            // 
            this.lblRegistrosMateria.AutoSize = true;
            this.lblRegistrosMateria.Location = new System.Drawing.Point(117, 35);
            this.lblRegistrosMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrosMateria.Name = "lblRegistrosMateria";
            this.lblRegistrosMateria.Size = new System.Drawing.Size(42, 16);
            this.lblRegistrosMateria.TabIndex = 10;
            this.lblRegistrosMateria.Text = "x de n";
            // 
            // btnUltimoMateria
            // 
            this.btnUltimoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoMateria.Location = new System.Drawing.Point(241, 17);
            this.btnUltimoMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimoMateria.Name = "btnUltimoMateria";
            this.btnUltimoMateria.Size = new System.Drawing.Size(44, 46);
            this.btnUltimoMateria.TabIndex = 3;
            this.btnUltimoMateria.Text = ">|";
            this.btnUltimoMateria.UseVisualStyleBackColor = true;
            this.btnUltimoMateria.Click += new System.EventHandler(this.btnUltimoMateria_Click);
            // 
            // btnSiguienteMateria
            // 
            this.btnSiguienteMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteMateria.Location = new System.Drawing.Point(193, 17);
            this.btnSiguienteMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguienteMateria.Name = "btnSiguienteMateria";
            this.btnSiguienteMateria.Size = new System.Drawing.Size(44, 46);
            this.btnSiguienteMateria.TabIndex = 2;
            this.btnSiguienteMateria.Text = ">";
            this.btnSiguienteMateria.UseVisualStyleBackColor = true;
            this.btnSiguienteMateria.Click += new System.EventHandler(this.btnSiguienteMateria_Click);
            // 
            // btnAnteriorMateria
            // 
            this.btnAnteriorMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorMateria.Location = new System.Drawing.Point(56, 17);
            this.btnAnteriorMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnteriorMateria.Name = "btnAnteriorMateria";
            this.btnAnteriorMateria.Size = new System.Drawing.Size(44, 46);
            this.btnAnteriorMateria.TabIndex = 1;
            this.btnAnteriorMateria.Text = "<";
            this.btnAnteriorMateria.UseVisualStyleBackColor = true;
            this.btnAnteriorMateria.Click += new System.EventHandler(this.btnAnteriorMateria_Click);
            // 
            // btnPrimeroMateria
            // 
            this.btnPrimeroMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroMateria.Location = new System.Drawing.Point(8, 17);
            this.btnPrimeroMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimeroMateria.Name = "btnPrimeroMateria";
            this.btnPrimeroMateria.Size = new System.Drawing.Size(44, 46);
            this.btnPrimeroMateria.TabIndex = 0;
            this.btnPrimeroMateria.Text = "|<";
            this.btnPrimeroMateria.UseVisualStyleBackColor = true;
            this.btnPrimeroMateria.Click += new System.EventHandler(this.btnPrimeroMateria_Click);
            // 
            // grbEdicionMateria
            // 
            this.grbEdicionMateria.Controls.Add(this.btnEliminarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnModificarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnAgregarMateria);
            this.grbEdicionMateria.Location = new System.Drawing.Point(385, 373);
            this.grbEdicionMateria.Margin = new System.Windows.Forms.Padding(4);
            this.grbEdicionMateria.Name = "grbEdicionMateria";
            this.grbEdicionMateria.Padding = new System.Windows.Forms.Padding(4);
            this.grbEdicionMateria.Size = new System.Drawing.Size(419, 72);
            this.grbEdicionMateria.TabIndex = 12;
            this.grbEdicionMateria.TabStop = false;
            this.grbEdicionMateria.Text = "Edicion";
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMateria.Location = new System.Drawing.Point(275, 18);
            this.btnEliminarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(133, 46);
            this.btnEliminarMateria.TabIndex = 3;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            this.btnEliminarMateria.Click += new System.EventHandler(this.btnEliminarMateria_Click);
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMateria.Location = new System.Drawing.Point(135, 17);
            this.btnModificarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(140, 46);
            this.btnModificarMateria.TabIndex = 1;
            this.btnModificarMateria.Text = "Modificar";
            this.btnModificarMateria.UseVisualStyleBackColor = true;
            this.btnModificarMateria.Click += new System.EventHandler(this.btnModificarMateria_Click);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMateria.Location = new System.Drawing.Point(8, 18);
            this.btnAgregarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(125, 46);
            this.btnAgregarMateria.TabIndex = 0;
            this.btnAgregarMateria.Text = "Nuevo";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // grbBusquedaMateria
            // 
            this.grbBusquedaMateria.Controls.Add(this.cboBuscarMaterias);
            this.grbBusquedaMateria.Controls.Add(this.grdMateria);
            this.grbBusquedaMateria.Controls.Add(this.txtBuscarMateria);
            this.grbBusquedaMateria.Location = new System.Drawing.Point(352, 67);
            this.grbBusquedaMateria.Margin = new System.Windows.Forms.Padding(4);
            this.grbBusquedaMateria.Name = "grbBusquedaMateria";
            this.grbBusquedaMateria.Padding = new System.Windows.Forms.Padding(4);
            this.grbBusquedaMateria.Size = new System.Drawing.Size(460, 275);
            this.grbBusquedaMateria.TabIndex = 11;
            this.grbBusquedaMateria.TabStop = false;
            this.grbBusquedaMateria.Text = "Busqueda Materias";
            this.grbBusquedaMateria.Enter += new System.EventHandler(this.grbBusquedaMateria_Enter);
            // 
            // cboBuscarMaterias
            // 
            this.cboBuscarMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarMaterias.FormattingEnabled = true;
            this.cboBuscarMaterias.Items.AddRange(new object[] {
            "Codigo",
            "Materia"});
            this.cboBuscarMaterias.Location = new System.Drawing.Point(8, 35);
            this.cboBuscarMaterias.Margin = new System.Windows.Forms.Padding(4);
            this.cboBuscarMaterias.Name = "cboBuscarMaterias";
            this.cboBuscarMaterias.Size = new System.Drawing.Size(145, 24);
            this.cboBuscarMaterias.TabIndex = 13;
            // 
            // grdMateria
            // 
            this.grdMateria.AllowUserToAddRows = false;
            this.grdMateria.AllowUserToDeleteRows = false;
            this.grdMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.uv});
            this.grdMateria.Location = new System.Drawing.Point(16, 74);
            this.grdMateria.Margin = new System.Windows.Forms.Padding(4);
            this.grdMateria.Name = "grdMateria";
            this.grdMateria.ReadOnly = true;
            this.grdMateria.RowHeadersWidth = 51;
            this.grdMateria.Size = new System.Drawing.Size(444, 201);
            this.grdMateria.TabIndex = 11;
            this.grdMateria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMateria_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "idMateria";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // uv
            // 
            this.uv.DataPropertyName = "uv";
            this.uv.HeaderText = "UV";
            this.uv.MinimumWidth = 6;
            this.uv.Name = "uv";
            this.uv.ReadOnly = true;
            this.uv.Width = 200;
            // 
            // txtBuscarMateria
            // 
            this.txtBuscarMateria.Location = new System.Drawing.Point(250, 37);
            this.txtBuscarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarMateria.Name = "txtBuscarMateria";
            this.txtBuscarMateria.Size = new System.Drawing.Size(202, 22);
            this.txtBuscarMateria.TabIndex = 10;
            this.txtBuscarMateria.TextChanged += new System.EventHandler(this.txtBuscarMateria_TextChanged);
            // 
            // grbDatosMateria
            // 
            this.grbDatosMateria.Controls.Add(this.idMateria);
            this.grbDatosMateria.Controls.Add(this.lblUvMateria);
            this.grbDatosMateria.Controls.Add(this.txtUvMateria);
            this.grbDatosMateria.Controls.Add(this.lblNombreMateria);
            this.grbDatosMateria.Controls.Add(this.txtNombreMateria);
            this.grbDatosMateria.Controls.Add(this.lblCodigoMateria);
            this.grbDatosMateria.Controls.Add(this.txtCodigoMateria);
            this.grbDatosMateria.Controls.Add(this.lblIdMateria);
            this.grbDatosMateria.Enabled = false;
            this.grbDatosMateria.Location = new System.Drawing.Point(13, 67);
            this.grbDatosMateria.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatosMateria.Name = "grbDatosMateria";
            this.grbDatosMateria.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatosMateria.Size = new System.Drawing.Size(307, 267);
            this.grbDatosMateria.TabIndex = 13;
            this.grbDatosMateria.TabStop = false;
            this.grbDatosMateria.Text = "DATOS";
            // 
            // idMateria
            // 
            this.idMateria.AutoSize = true;
            this.idMateria.Location = new System.Drawing.Point(107, 47);
            this.idMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idMateria.Name = "idMateria";
            this.idMateria.Size = new System.Drawing.Size(44, 16);
            this.idMateria.TabIndex = 9;
            this.idMateria.Text = "label1";
            // 
            // lblUvMateria
            // 
            this.lblUvMateria.AutoSize = true;
            this.lblUvMateria.Location = new System.Drawing.Point(7, 193);
            this.lblUvMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUvMateria.Name = "lblUvMateria";
            this.lblUvMateria.Size = new System.Drawing.Size(29, 16);
            this.lblUvMateria.TabIndex = 6;
            this.lblUvMateria.Text = "UV:";
            // 
            // txtUvMateria
            // 
            this.txtUvMateria.Location = new System.Drawing.Point(107, 188);
            this.txtUvMateria.Margin = new System.Windows.Forms.Padding(4);
            this.txtUvMateria.Name = "txtUvMateria";
            this.txtUvMateria.Size = new System.Drawing.Size(132, 22);
            this.txtUvMateria.TabIndex = 5;
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Location = new System.Drawing.Point(23, 137);
            this.lblNombreMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(69, 16);
            this.lblNombreMateria.TabIndex = 4;
            this.lblNombreMateria.Text = "NOMBRE:";
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(107, 132);
            this.txtNombreMateria.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(132, 22);
            this.txtNombreMateria.TabIndex = 3;
            // 
            // lblCodigoMateria
            // 
            this.lblCodigoMateria.AutoSize = true;
            this.lblCodigoMateria.Location = new System.Drawing.Point(29, 89);
            this.lblCodigoMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoMateria.Name = "lblCodigoMateria";
            this.lblCodigoMateria.Size = new System.Drawing.Size(62, 16);
            this.lblCodigoMateria.TabIndex = 2;
            this.lblCodigoMateria.Text = "CODIGO:";
            // 
            // txtCodigoMateria
            // 
            this.txtCodigoMateria.Location = new System.Drawing.Point(107, 89);
            this.txtCodigoMateria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoMateria.Name = "txtCodigoMateria";
            this.txtCodigoMateria.Size = new System.Drawing.Size(132, 22);
            this.txtCodigoMateria.TabIndex = 1;
            // 
            // lblIdMateria
            // 
            this.lblIdMateria.AutoSize = true;
            this.lblIdMateria.Location = new System.Drawing.Point(71, 43);
            this.lblIdMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdMateria.Name = "lblIdMateria";
            this.lblIdMateria.Size = new System.Drawing.Size(23, 16);
            this.lblIdMateria.TabIndex = 0;
            this.lblIdMateria.Text = "ID:";
            // 
            // frmMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 552);
            this.Controls.Add(this.grbDatosMateria);
            this.Controls.Add(this.grbEdicionMateria);
            this.Controls.Add(this.grbBusquedaMateria);
            this.Controls.Add(this.grbNavegacionMateria);
            this.Name = "frmMateria";
            this.Text = "frmMateria";
            this.Load += new System.EventHandler(this.frmMateria_Load);
            this.grbNavegacionMateria.ResumeLayout(false);
            this.grbNavegacionMateria.PerformLayout();
            this.grbEdicionMateria.ResumeLayout(false);
            this.grbBusquedaMateria.ResumeLayout(false);
            this.grbBusquedaMateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMateria)).EndInit();
            this.grbDatosMateria.ResumeLayout(false);
            this.grbDatosMateria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbNavegacionMateria;
        private System.Windows.Forms.Label lblRegistrosMateria;
        private System.Windows.Forms.Button btnUltimoMateria;
        private System.Windows.Forms.Button btnSiguienteMateria;
        private System.Windows.Forms.Button btnAnteriorMateria;
        private System.Windows.Forms.Button btnPrimeroMateria;
        private System.Windows.Forms.GroupBox grbEdicionMateria;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.GroupBox grbBusquedaMateria;
        private System.Windows.Forms.DataGridView grdMateria;
        private System.Windows.Forms.TextBox txtBuscarMateria;
        private System.Windows.Forms.GroupBox grbDatosMateria;
        private System.Windows.Forms.Label idMateria;
        private System.Windows.Forms.Label lblUvMateria;
        private System.Windows.Forms.TextBox txtUvMateria;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label lblCodigoMateria;
        private System.Windows.Forms.TextBox txtCodigoMateria;
        private System.Windows.Forms.Label lblIdMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn uv;
        private System.Windows.Forms.ComboBox cboBuscarMaterias;
    }
}