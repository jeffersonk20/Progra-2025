namespace miPrimerProyectoCsharp
{
    partial class Academica
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbDatosAlumnos = new System.Windows.Forms.GroupBox();
            this.txtTelefonoAlumno = new System.Windows.Forms.TextBox();
            this.txtDireccionAlumno = new System.Windows.Forms.TextBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.lblTelefonoAlumno = new System.Windows.Forms.Label();
            this.lblDireccionAlumno = new System.Windows.Forms.Label();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.idAlumno = new System.Windows.Forms.Label();
            this.lblIdAlumnos = new System.Windows.Forms.Label();
            this.grbNavegacionAlumno = new System.Windows.Forms.GroupBox();
            this.lblRegistroAlumno = new System.Windows.Forms.Label();
            this.btnUltimoAlumno = new System.Windows.Forms.Button();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.btnAnteriorAlumno = new System.Windows.Forms.Button();
            this.btnPrimeroAlumno = new System.Windows.Forms.Button();
            this.grbEdicionAlumno = new System.Windows.Forms.GroupBox();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.grbBusquedaAlumno = new System.Windows.Forms.GroupBox();
            this.txtBuscarAlumnos = new System.Windows.Forms.TextBox();
            this.grdAlumnos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDatosAlumnos.SuspendLayout();
            this.grbNavegacionAlumno.SuspendLayout();
            this.grbEdicionAlumno.SuspendLayout();
            this.grbBusquedaAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosAlumnos
            // 
            this.grbDatosAlumnos.Controls.Add(this.txtTelefonoAlumno);
            this.grbDatosAlumnos.Controls.Add(this.txtDireccionAlumno);
            this.grbDatosAlumnos.Controls.Add(this.txtNombreAlumno);
            this.grbDatosAlumnos.Controls.Add(this.txtCodigoAlumno);
            this.grbDatosAlumnos.Controls.Add(this.lblTelefonoAlumno);
            this.grbDatosAlumnos.Controls.Add(this.lblDireccionAlumno);
            this.grbDatosAlumnos.Controls.Add(this.lblNombreAlumno);
            this.grbDatosAlumnos.Controls.Add(this.lblCodigoAlumno);
            this.grbDatosAlumnos.Controls.Add(this.idAlumno);
            this.grbDatosAlumnos.Controls.Add(this.lblIdAlumnos);
            this.grbDatosAlumnos.Location = new System.Drawing.Point(36, 73);
            this.grbDatosAlumnos.Name = "grbDatosAlumnos";
            this.grbDatosAlumnos.Size = new System.Drawing.Size(243, 310);
            this.grbDatosAlumnos.TabIndex = 0;
            this.grbDatosAlumnos.TabStop = false;
            this.grbDatosAlumnos.Text = "DATOS:";
            // 
            // txtTelefonoAlumno
            // 
            this.txtTelefonoAlumno.Location = new System.Drawing.Point(105, 235);
            this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            this.txtTelefonoAlumno.Size = new System.Drawing.Size(125, 22);
            this.txtTelefonoAlumno.TabIndex = 9;
            // 
            // txtDireccionAlumno
            // 
            this.txtDireccionAlumno.Location = new System.Drawing.Point(105, 186);
            this.txtDireccionAlumno.Name = "txtDireccionAlumno";
            this.txtDireccionAlumno.Size = new System.Drawing.Size(125, 22);
            this.txtDireccionAlumno.TabIndex = 8;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(105, 145);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(125, 22);
            this.txtNombreAlumno.TabIndex = 7;
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Location = new System.Drawing.Point(105, 104);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.Size = new System.Drawing.Size(125, 22);
            this.txtCodigoAlumno.TabIndex = 6;
            // 
            // lblTelefonoAlumno
            // 
            this.lblTelefonoAlumno.AutoSize = true;
            this.lblTelefonoAlumno.Location = new System.Drawing.Point(29, 238);
            this.lblTelefonoAlumno.Name = "lblTelefonoAlumno";
            this.lblTelefonoAlumno.Size = new System.Drawing.Size(64, 16);
            this.lblTelefonoAlumno.TabIndex = 5;
            this.lblTelefonoAlumno.Text = "Telefono:";
            // 
            // lblDireccionAlumno
            // 
            this.lblDireccionAlumno.AutoSize = true;
            this.lblDireccionAlumno.Location = new System.Drawing.Point(29, 189);
            this.lblDireccionAlumno.Name = "lblDireccionAlumno";
            this.lblDireccionAlumno.Size = new System.Drawing.Size(67, 16);
            this.lblDireccionAlumno.TabIndex = 4;
            this.lblDireccionAlumno.Text = "Direccion:";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Location = new System.Drawing.Point(29, 145);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(59, 16);
            this.lblNombreAlumno.TabIndex = 3;
            this.lblNombreAlumno.Text = "Nombre:";
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Location = new System.Drawing.Point(29, 104);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoAlumno.TabIndex = 2;
            this.lblCodigoAlumno.Text = "Codigo:";
            // 
            // idAlumno
            // 
            this.idAlumno.AutoSize = true;
            this.idAlumno.Location = new System.Drawing.Point(58, 57);
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.Size = new System.Drawing.Size(44, 16);
            this.idAlumno.TabIndex = 1;
            this.idAlumno.Text = "label2";
            // 
            // lblIdAlumnos
            // 
            this.lblIdAlumnos.AutoSize = true;
            this.lblIdAlumnos.Location = new System.Drawing.Point(29, 57);
            this.lblIdAlumnos.Name = "lblIdAlumnos";
            this.lblIdAlumnos.Size = new System.Drawing.Size(23, 16);
            this.lblIdAlumnos.TabIndex = 0;
            this.lblIdAlumnos.Text = "ID:";
            // 
            // grbNavegacionAlumno
            // 
            this.grbNavegacionAlumno.Controls.Add(this.lblRegistroAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnUltimoAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnSiguienteAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnAnteriorAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnPrimeroAlumno);
            this.grbNavegacionAlumno.Location = new System.Drawing.Point(36, 410);
            this.grbNavegacionAlumno.Name = "grbNavegacionAlumno";
            this.grbNavegacionAlumno.Size = new System.Drawing.Size(263, 99);
            this.grbNavegacionAlumno.TabIndex = 1;
            this.grbNavegacionAlumno.TabStop = false;
            this.grbNavegacionAlumno.Text = "NAVEGACION";
            // 
            // lblRegistroAlumno
            // 
            this.lblRegistroAlumno.AutoSize = true;
            this.lblRegistroAlumno.Location = new System.Drawing.Point(117, 38);
            this.lblRegistroAlumno.Name = "lblRegistroAlumno";
            this.lblRegistroAlumno.Size = new System.Drawing.Size(42, 16);
            this.lblRegistroAlumno.TabIndex = 3;
            this.lblRegistroAlumno.Text = "x de n";
            // 
            // btnUltimoAlumno
            // 
            this.btnUltimoAlumno.Location = new System.Drawing.Point(214, 21);
            this.btnUltimoAlumno.Name = "btnUltimoAlumno";
            this.btnUltimoAlumno.Size = new System.Drawing.Size(43, 50);
            this.btnUltimoAlumno.TabIndex = 3;
            this.btnUltimoAlumno.Text = ">|";
            this.btnUltimoAlumno.UseVisualStyleBackColor = true;
            this.btnUltimoAlumno.Click += new System.EventHandler(this.btnUltimoAlumno_Click);
            // 
            // btnSiguienteAlumno
            // 
            this.btnSiguienteAlumno.Location = new System.Drawing.Point(165, 21);
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(43, 50);
            this.btnSiguienteAlumno.TabIndex = 2;
            this.btnSiguienteAlumno.Text = ">";
            this.btnSiguienteAlumno.UseVisualStyleBackColor = true;
            this.btnSiguienteAlumno.Click += new System.EventHandler(this.btnSiguienteAlumno_Click);
            // 
            // btnAnteriorAlumno
            // 
            this.btnAnteriorAlumno.Location = new System.Drawing.Point(68, 21);
            this.btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            this.btnAnteriorAlumno.Size = new System.Drawing.Size(43, 50);
            this.btnAnteriorAlumno.TabIndex = 1;
            this.btnAnteriorAlumno.Text = "<";
            this.btnAnteriorAlumno.UseVisualStyleBackColor = true;
            this.btnAnteriorAlumno.Click += new System.EventHandler(this.btnAnteriorAlumno_Click);
            // 
            // btnPrimeroAlumno
            // 
            this.btnPrimeroAlumno.Location = new System.Drawing.Point(19, 21);
            this.btnPrimeroAlumno.Name = "btnPrimeroAlumno";
            this.btnPrimeroAlumno.Size = new System.Drawing.Size(43, 50);
            this.btnPrimeroAlumno.TabIndex = 0;
            this.btnPrimeroAlumno.Text = "|<";
            this.btnPrimeroAlumno.UseVisualStyleBackColor = true;
            this.btnPrimeroAlumno.Click += new System.EventHandler(this.btnPrimeroAlumno_Click);
            // 
            // grbEdicionAlumno
            // 
            this.grbEdicionAlumno.Controls.Add(this.btnEliminarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnModificarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnAgregarAlumno);
            this.grbEdicionAlumno.Location = new System.Drawing.Point(330, 410);
            this.grbEdicionAlumno.Name = "grbEdicionAlumno";
            this.grbEdicionAlumno.Size = new System.Drawing.Size(263, 99);
            this.grbEdicionAlumno.TabIndex = 2;
            this.grbEdicionAlumno.TabStop = false;
            this.grbEdicionAlumno.Text = "EDICIÓN";
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Location = new System.Drawing.Point(184, 21);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(64, 50);
            this.btnEliminarAlumno.TabIndex = 2;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Location = new System.Drawing.Point(84, 21);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(83, 50);
            this.btnModificarAlumno.TabIndex = 1;
            this.btnModificarAlumno.Text = "Modificar";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click);
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(6, 21);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(56, 50);
            this.btnAgregarAlumno.TabIndex = 0;
            this.btnAgregarAlumno.Text = "Nuevo";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // grbBusquedaAlumno
            // 
            this.grbBusquedaAlumno.Controls.Add(this.txtBuscarAlumnos);
            this.grbBusquedaAlumno.Controls.Add(this.grdAlumnos);
            this.grbBusquedaAlumno.Location = new System.Drawing.Point(285, 73);
            this.grbBusquedaAlumno.Name = "grbBusquedaAlumno";
            this.grbBusquedaAlumno.Size = new System.Drawing.Size(537, 310);
            this.grbBusquedaAlumno.TabIndex = 3;
            this.grbBusquedaAlumno.TabStop = false;
            this.grbBusquedaAlumno.Text = "Busqueda Alumnos";
            // 
            // txtBuscarAlumnos
            // 
            this.txtBuscarAlumnos.Location = new System.Drawing.Point(7, 29);
            this.txtBuscarAlumnos.Name = "txtBuscarAlumnos";
            this.txtBuscarAlumnos.Size = new System.Drawing.Size(524, 22);
            this.txtBuscarAlumnos.TabIndex = 1;
            this.txtBuscarAlumnos.TextChanged += new System.EventHandler(this.txtBuscarAlumnos_TextChanged);
            // 
            // grdAlumnos
            // 
            this.grdAlumnos.AllowUserToAddRows = false;
            this.grdAlumnos.AllowUserToDeleteRows = false;
            this.grdAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo,
            this.Nombre,
            this.direccion,
            this.telefono});
            this.grdAlumnos.Location = new System.Drawing.Point(8, 66);
            this.grdAlumnos.Margin = new System.Windows.Forms.Padding(4);
            this.grdAlumnos.Name = "grdAlumnos";
            this.grdAlumnos.ReadOnly = true;
            this.grdAlumnos.RowHeadersWidth = 51;
            this.grdAlumnos.RowTemplate.Height = 24;
            this.grdAlumnos.Size = new System.Drawing.Size(522, 237);
            this.grdAlumnos.TabIndex = 11;
            this.grdAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAlumnos_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "idAlumno";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo";
            this.Codigo.HeaderText = "CODIGO";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 125;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // Academica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 658);
            this.Controls.Add(this.grbBusquedaAlumno);
            this.Controls.Add(this.grbEdicionAlumno);
            this.Controls.Add(this.grbNavegacionAlumno);
            this.Controls.Add(this.grbDatosAlumnos);
            this.Name = "Academica";
            this.Text = "administracion de alumnos";
            this.Load += new System.EventHandler(this.Academica_Load);
            this.grbDatosAlumnos.ResumeLayout(false);
            this.grbDatosAlumnos.PerformLayout();
            this.grbNavegacionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.PerformLayout();
            this.grbEdicionAlumno.ResumeLayout(false);
            this.grbBusquedaAlumno.ResumeLayout(false);
            this.grbBusquedaAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosAlumnos;
        private System.Windows.Forms.Label lblIdAlumnos;
        private System.Windows.Forms.GroupBox grbNavegacionAlumno;
        private System.Windows.Forms.Label lblTelefonoAlumno;
        private System.Windows.Forms.Label lblDireccionAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.Label idAlumno;
        private System.Windows.Forms.TextBox txtTelefonoAlumno;
        private System.Windows.Forms.TextBox txtDireccionAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.Button btnPrimeroAlumno;
        private System.Windows.Forms.Button btnUltimoAlumno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.GroupBox grbEdicionAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Label lblRegistroAlumno;
        private System.Windows.Forms.GroupBox grbBusquedaAlumno;
        private System.Windows.Forms.DataGridView grdAlumnos;
        private System.Windows.Forms.TextBox txtBuscarAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    }
}

