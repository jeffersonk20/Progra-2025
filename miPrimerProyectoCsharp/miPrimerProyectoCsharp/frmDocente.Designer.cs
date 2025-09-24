namespace miPrimerProyectoCsharp
{
    partial class frmDocente
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
            this.grbEdicionDocente = new System.Windows.Forms.GroupBox();
            this.btnEliminarDocente = new System.Windows.Forms.Button();
            this.btnModificarDocente = new System.Windows.Forms.Button();
            this.btnAgregarDocente = new System.Windows.Forms.Button();
            this.grbBusquedaDocente = new System.Windows.Forms.GroupBox();
            this.grdDocentes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarDocentes = new System.Windows.Forms.TextBox();
            this.grbDatosDocente = new System.Windows.Forms.GroupBox();
            this.idDocente = new System.Windows.Forms.Label();
            this.lblTelefonoDocente = new System.Windows.Forms.Label();
            this.txtTelefonoDocente = new System.Windows.Forms.TextBox();
            this.lblDireccionDocente = new System.Windows.Forms.Label();
            this.txtDireccionDocente = new System.Windows.Forms.TextBox();
            this.lblNombreDocente = new System.Windows.Forms.Label();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.lblCodigoDocente = new System.Windows.Forms.Label();
            this.txtCodigoDocente = new System.Windows.Forms.TextBox();
            this.lblIdDocente = new System.Windows.Forms.Label();
            this.grbNavegacionDocente = new System.Windows.Forms.GroupBox();
            this.lblRegistrosDocente = new System.Windows.Forms.Label();
            this.btnUltimoDocente = new System.Windows.Forms.Button();
            this.btnSiguienteDocente = new System.Windows.Forms.Button();
            this.btnAnteriorDocente = new System.Windows.Forms.Button();
            this.btnPrimeroDocente = new System.Windows.Forms.Button();
            this.grbEdicionDocente.SuspendLayout();
            this.grbBusquedaDocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocentes)).BeginInit();
            this.grbDatosDocente.SuspendLayout();
            this.grbNavegacionDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEdicionDocente
            // 
            this.grbEdicionDocente.Controls.Add(this.btnEliminarDocente);
            this.grbEdicionDocente.Controls.Add(this.btnModificarDocente);
            this.grbEdicionDocente.Controls.Add(this.btnAgregarDocente);
            this.grbEdicionDocente.Location = new System.Drawing.Point(527, 437);
            this.grbEdicionDocente.Margin = new System.Windows.Forms.Padding(4);
            this.grbEdicionDocente.Name = "grbEdicionDocente";
            this.grbEdicionDocente.Padding = new System.Windows.Forms.Padding(4);
            this.grbEdicionDocente.Size = new System.Drawing.Size(462, 75);
            this.grbEdicionDocente.TabIndex = 10;
            this.grbEdicionDocente.TabStop = false;
            this.grbEdicionDocente.Text = "Edicion";
            // 
            // btnEliminarDocente
            // 
            this.btnEliminarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDocente.Location = new System.Drawing.Point(275, 18);
            this.btnEliminarDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarDocente.Name = "btnEliminarDocente";
            this.btnEliminarDocente.Size = new System.Drawing.Size(133, 46);
            this.btnEliminarDocente.TabIndex = 3;
            this.btnEliminarDocente.Text = "Eliminar";
            this.btnEliminarDocente.UseVisualStyleBackColor = true;
            this.btnEliminarDocente.Click += new System.EventHandler(this.btnEliminarDocente_Click);
            // 
            // btnModificarDocente
            // 
            this.btnModificarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDocente.Location = new System.Drawing.Point(135, 17);
            this.btnModificarDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarDocente.Name = "btnModificarDocente";
            this.btnModificarDocente.Size = new System.Drawing.Size(140, 46);
            this.btnModificarDocente.TabIndex = 1;
            this.btnModificarDocente.Text = "Modificar";
            this.btnModificarDocente.UseVisualStyleBackColor = true;
            this.btnModificarDocente.Click += new System.EventHandler(this.btnModificarDocente_Click);
            // 
            // btnAgregarDocente
            // 
            this.btnAgregarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDocente.Location = new System.Drawing.Point(8, 18);
            this.btnAgregarDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarDocente.Name = "btnAgregarDocente";
            this.btnAgregarDocente.Size = new System.Drawing.Size(125, 46);
            this.btnAgregarDocente.TabIndex = 0;
            this.btnAgregarDocente.Text = "Nuevo";
            this.btnAgregarDocente.UseVisualStyleBackColor = true;
            this.btnAgregarDocente.Click += new System.EventHandler(this.btnAgregarDocente_Click);
            // 
            // grbBusquedaDocente
            // 
            this.grbBusquedaDocente.Controls.Add(this.grdDocentes);
            this.grbBusquedaDocente.Controls.Add(this.txtBuscarDocentes);
            this.grbBusquedaDocente.Location = new System.Drawing.Point(527, 52);
            this.grbBusquedaDocente.Margin = new System.Windows.Forms.Padding(4);
            this.grbBusquedaDocente.Name = "grbBusquedaDocente";
            this.grbBusquedaDocente.Padding = new System.Windows.Forms.Padding(4);
            this.grbBusquedaDocente.Size = new System.Drawing.Size(640, 344);
            this.grbBusquedaDocente.TabIndex = 9;
            this.grbBusquedaDocente.TabStop = false;
            this.grbBusquedaDocente.Text = "Busqueda Docentes";
            // 
            // grdDocentes
            // 
            this.grdDocentes.AllowUserToAddRows = false;
            this.grdDocentes.AllowUserToDeleteRows = false;
            this.grdDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdDocentes.Location = new System.Drawing.Point(8, 66);
            this.grdDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.grdDocentes.Name = "grdDocentes";
            this.grdDocentes.ReadOnly = true;
            this.grdDocentes.RowHeadersWidth = 51;
            this.grdDocentes.Size = new System.Drawing.Size(619, 265);
            this.grdDocentes.TabIndex = 11;

            // 
            // id
            // 
            this.id.DataPropertyName = "idDocente";
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
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 200;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TEL";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // txtBuscarDocentes
            // 
            this.txtBuscarDocentes.Location = new System.Drawing.Point(8, 34);
            this.txtBuscarDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarDocentes.Name = "txtBuscarDocentes";
            this.txtBuscarDocentes.Size = new System.Drawing.Size(545, 22);
            this.txtBuscarDocentes.TabIndex = 10;
            this.txtBuscarDocentes.TextChanged += new System.EventHandler(this.txtBuscarDocentes_TextChanged);
            // 
            // grbDatosDocente
            // 
            this.grbDatosDocente.Controls.Add(this.idDocente);
            this.grbDatosDocente.Controls.Add(this.lblTelefonoDocente);
            this.grbDatosDocente.Controls.Add(this.txtTelefonoDocente);
            this.grbDatosDocente.Controls.Add(this.lblDireccionDocente);
            this.grbDatosDocente.Controls.Add(this.txtDireccionDocente);
            this.grbDatosDocente.Controls.Add(this.lblNombreDocente);
            this.grbDatosDocente.Controls.Add(this.txtNombreDocente);
            this.grbDatosDocente.Controls.Add(this.lblCodigoDocente);
            this.grbDatosDocente.Controls.Add(this.txtCodigoDocente);
            this.grbDatosDocente.Controls.Add(this.lblIdDocente);
            this.grbDatosDocente.Enabled = false;
            this.grbDatosDocente.Location = new System.Drawing.Point(47, 52);
            this.grbDatosDocente.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatosDocente.Name = "grbDatosDocente";
            this.grbDatosDocente.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatosDocente.Size = new System.Drawing.Size(466, 344);
            this.grbDatosDocente.TabIndex = 8;
            this.grbDatosDocente.TabStop = false;
            this.grbDatosDocente.Text = "DATOS";
            // 
            // idDocente
            // 
            this.idDocente.AutoSize = true;
            this.idDocente.Location = new System.Drawing.Point(107, 47);
            this.idDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idDocente.Name = "idDocente";
            this.idDocente.Size = new System.Drawing.Size(44, 16);
            this.idDocente.TabIndex = 9;
            this.idDocente.Text = "label1";
            // 
            // lblTelefonoDocente
            // 
            this.lblTelefonoDocente.AutoSize = true;
            this.lblTelefonoDocente.Location = new System.Drawing.Point(59, 252);
            this.lblTelefonoDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoDocente.Name = "lblTelefonoDocente";
            this.lblTelefonoDocente.Size = new System.Drawing.Size(35, 16);
            this.lblTelefonoDocente.TabIndex = 8;
            this.lblTelefonoDocente.Text = "TEL:";
            // 
            // txtTelefonoDocente
            // 
            this.txtTelefonoDocente.Location = new System.Drawing.Point(107, 247);
            this.txtTelefonoDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoDocente.Name = "txtTelefonoDocente";
            this.txtTelefonoDocente.Size = new System.Drawing.Size(132, 22);
            this.txtTelefonoDocente.TabIndex = 7;
            // 
            // lblDireccionDocente
            // 
            this.lblDireccionDocente.AutoSize = true;
            this.lblDireccionDocente.Location = new System.Drawing.Point(7, 193);
            this.lblDireccionDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionDocente.Name = "lblDireccionDocente";
            this.lblDireccionDocente.Size = new System.Drawing.Size(83, 16);
            this.lblDireccionDocente.TabIndex = 6;
            this.lblDireccionDocente.Text = "DIRECCION:";
            // 
            // txtDireccionDocente
            // 
            this.txtDireccionDocente.Location = new System.Drawing.Point(107, 188);
            this.txtDireccionDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionDocente.Name = "txtDireccionDocente";
            this.txtDireccionDocente.Size = new System.Drawing.Size(347, 22);
            this.txtDireccionDocente.TabIndex = 5;
            // 
            // lblNombreDocente
            // 
            this.lblNombreDocente.AutoSize = true;
            this.lblNombreDocente.Location = new System.Drawing.Point(23, 137);
            this.lblNombreDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreDocente.Name = "lblNombreDocente";
            this.lblNombreDocente.Size = new System.Drawing.Size(69, 16);
            this.lblNombreDocente.TabIndex = 4;
            this.lblNombreDocente.Text = "NOMBRE:";
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(107, 132);
            this.txtNombreDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(273, 22);
            this.txtNombreDocente.TabIndex = 3;
            // 
            // lblCodigoDocente
            // 
            this.lblCodigoDocente.AutoSize = true;
            this.lblCodigoDocente.Location = new System.Drawing.Point(29, 89);
            this.lblCodigoDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoDocente.Name = "lblCodigoDocente";
            this.lblCodigoDocente.Size = new System.Drawing.Size(62, 16);
            this.lblCodigoDocente.TabIndex = 2;
            this.lblCodigoDocente.Text = "CODIGO:";
            // 
            // txtCodigoDocente
            // 
            this.txtCodigoDocente.Location = new System.Drawing.Point(107, 89);
            this.txtCodigoDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoDocente.Name = "txtCodigoDocente";
            this.txtCodigoDocente.Size = new System.Drawing.Size(132, 22);
            this.txtCodigoDocente.TabIndex = 1;
            // 
            // lblIdDocente
            // 
            this.lblIdDocente.AutoSize = true;
            this.lblIdDocente.Location = new System.Drawing.Point(71, 43);
            this.lblIdDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdDocente.Name = "lblIdDocente";
            this.lblIdDocente.Size = new System.Drawing.Size(23, 16);
            this.lblIdDocente.TabIndex = 0;
            this.lblIdDocente.Text = "ID:";
            // 
            // grbNavegacionDocente
            // 
            this.grbNavegacionDocente.Controls.Add(this.lblRegistrosDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnUltimoDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnSiguienteDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnAnteriorDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnPrimeroDocente);
            this.grbNavegacionDocente.Location = new System.Drawing.Point(39, 437);
            this.grbNavegacionDocente.Margin = new System.Windows.Forms.Padding(4);
            this.grbNavegacionDocente.Name = "grbNavegacionDocente";
            this.grbNavegacionDocente.Padding = new System.Windows.Forms.Padding(4);
            this.grbNavegacionDocente.Size = new System.Drawing.Size(467, 75);
            this.grbNavegacionDocente.TabIndex = 7;
            this.grbNavegacionDocente.TabStop = false;
            this.grbNavegacionDocente.Text = "Navegacion";
            // 
            // lblRegistrosDocente
            // 
            this.lblRegistrosDocente.AutoSize = true;
            this.lblRegistrosDocente.Location = new System.Drawing.Point(117, 35);
            this.lblRegistrosDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrosDocente.Name = "lblRegistrosDocente";
            this.lblRegistrosDocente.Size = new System.Drawing.Size(42, 16);
            this.lblRegistrosDocente.TabIndex = 10;
            this.lblRegistrosDocente.Text = "x de n";
            // 
            // btnUltimoDocente
            // 
            this.btnUltimoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoDocente.Location = new System.Drawing.Point(241, 17);
            this.btnUltimoDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimoDocente.Name = "btnUltimoDocente";
            this.btnUltimoDocente.Size = new System.Drawing.Size(44, 46);
            this.btnUltimoDocente.TabIndex = 3;
            this.btnUltimoDocente.Text = ">|";
            this.btnUltimoDocente.UseVisualStyleBackColor = true;
            this.btnUltimoDocente.Click += new System.EventHandler(this.btnUltimoDocente_Click);
            // 
            // btnSiguienteDocente
            // 
            this.btnSiguienteDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteDocente.Location = new System.Drawing.Point(193, 17);
            this.btnSiguienteDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguienteDocente.Name = "btnSiguienteDocente";
            this.btnSiguienteDocente.Size = new System.Drawing.Size(44, 46);
            this.btnSiguienteDocente.TabIndex = 2;
            this.btnSiguienteDocente.Text = ">";
            this.btnSiguienteDocente.UseVisualStyleBackColor = true;
            this.btnSiguienteDocente.Click += new System.EventHandler(this.btnSiguienteDocente_Click_1);
            // 
            // btnAnteriorDocente
            // 
            this.btnAnteriorDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorDocente.Location = new System.Drawing.Point(56, 17);
            this.btnAnteriorDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnteriorDocente.Name = "btnAnteriorDocente";
            this.btnAnteriorDocente.Size = new System.Drawing.Size(44, 46);
            this.btnAnteriorDocente.TabIndex = 1;
            this.btnAnteriorDocente.Text = "<";
            this.btnAnteriorDocente.UseVisualStyleBackColor = true;
            this.btnAnteriorDocente.Click += new System.EventHandler(this.btnAnteriorDocente_Click);
            // 
            // btnPrimeroDocente
            // 
            this.btnPrimeroDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroDocente.Location = new System.Drawing.Point(8, 17);
            this.btnPrimeroDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimeroDocente.Name = "btnPrimeroDocente";
            this.btnPrimeroDocente.Size = new System.Drawing.Size(44, 46);
            this.btnPrimeroDocente.TabIndex = 0;
            this.btnPrimeroDocente.Text = "|<";
            this.btnPrimeroDocente.UseVisualStyleBackColor = true;
            this.btnPrimeroDocente.Click += new System.EventHandler(this.btnPrimeroDocente_Click);
            // 
            // frmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 551);
            this.Controls.Add(this.grbEdicionDocente);
            this.Controls.Add(this.grbBusquedaDocente);
            this.Controls.Add(this.grbDatosDocente);
            this.Controls.Add(this.grbNavegacionDocente);
            this.Name = "frmDocente";
            this.Text = "frmDocente";
            this.Load += new System.EventHandler(this.frmDocente_Load);
            this.grbEdicionDocente.ResumeLayout(false);
            this.grbBusquedaDocente.ResumeLayout(false);
            this.grbBusquedaDocente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocentes)).EndInit();
            this.grbDatosDocente.ResumeLayout(false);
            this.grbDatosDocente.PerformLayout();
            this.grbNavegacionDocente.ResumeLayout(false);
            this.grbNavegacionDocente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEdicionDocente;
        private System.Windows.Forms.Button btnEliminarDocente;
        private System.Windows.Forms.Button btnModificarDocente;
        private System.Windows.Forms.Button btnAgregarDocente;
        private System.Windows.Forms.GroupBox grbBusquedaDocente;
        private System.Windows.Forms.DataGridView grdDocentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.TextBox txtBuscarDocentes;
        private System.Windows.Forms.GroupBox grbDatosDocente;
        private System.Windows.Forms.Label idDocente;
        private System.Windows.Forms.Label lblTelefonoDocente;
        private System.Windows.Forms.TextBox txtTelefonoDocente;
        private System.Windows.Forms.Label lblDireccionDocente;
        private System.Windows.Forms.TextBox txtDireccionDocente;
        private System.Windows.Forms.Label lblNombreDocente;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.Label lblCodigoDocente;
        private System.Windows.Forms.TextBox txtCodigoDocente;
        private System.Windows.Forms.Label lblIdDocente;
        private System.Windows.Forms.GroupBox grbNavegacionDocente;
        private System.Windows.Forms.Label lblRegistrosDocente;
        private System.Windows.Forms.Button btnUltimoDocente;
        private System.Windows.Forms.Button btnSiguienteDocente;
        private System.Windows.Forms.Button btnAnteriorDocente;
        private System.Windows.Forms.Button btnPrimeroDocente;
    }
}