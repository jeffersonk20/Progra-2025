namespace Parcial2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label claveLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            this.db_parcialllDataSet = new Parcial2.db_parcialllDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new Parcial2.db_parcialllDataSetTableAdapters.usuarioTableAdapter();
            this.tableAdapterManager = new Parcial2.db_parcialllDataSetTableAdapters.TableAdapterManager();
            this.idUsuarioLabel1 = new System.Windows.Forms.Label();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.grbUsuario = new System.Windows.Forms.GroupBox();
            this.grbEdicionDocente = new System.Windows.Forms.GroupBox();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.grbNavegacionUsuario = new System.Windows.Forms.GroupBox();
            this.lblRegistrosUsuario = new System.Windows.Forms.Label();
            this.btnUltimoUsuario = new System.Windows.Forms.Button();
            this.btnSiguienteUsuario = new System.Windows.Forms.Button();
            this.btnAnteriorUsuario = new System.Windows.Forms.Button();
            this.btnPrimeroUsuario = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            idUsuarioLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_parcialllDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.grbUsuario.SuspendLayout();
            this.grbEdicionDocente.SuspendLayout();
            this.grbNavegacionUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // db_parcialllDataSet
            // 
            this.db_parcialllDataSet.DataSetName = "db_parcialllDataSet";
            this.db_parcialllDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.db_parcialllDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Parcial2.db_parcialllDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(23, 35);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(104, 23);
            idUsuarioLabel.TabIndex = 1;
            idUsuarioLabel.Text = "id Usuario:";
            // 
            // idUsuarioLabel1
            // 
            this.idUsuarioLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "idUsuario", true));
            this.idUsuarioLabel1.Location = new System.Drawing.Point(129, 35);
            this.idUsuarioLabel1.Name = "idUsuarioLabel1";
            this.idUsuarioLabel1.Size = new System.Drawing.Size(100, 23);
            this.idUsuarioLabel1.TabIndex = 2;
            this.idUsuarioLabel1.Text = "label1";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(23, 81);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(81, 23);
            usuarioLabel.TabIndex = 3;
            usuarioLabel.Text = "usuario:";
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(110, 73);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(152, 31);
            this.usuarioTextBox.TabIndex = 4;
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(26, 121);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(59, 23);
            claveLabel.TabIndex = 5;
            claveLabel.Text = "clave:";
            // 
            // claveTextBox
            // 
            this.claveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "clave", true));
            this.claveTextBox.Location = new System.Drawing.Point(91, 118);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.Size = new System.Drawing.Size(171, 31);
            this.claveTextBox.TabIndex = 6;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(26, 161);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(83, 23);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(115, 158);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(147, 31);
            this.nombreTextBox.TabIndex = 8;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(23, 201);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(96, 23);
            direccionLabel.TabIndex = 9;
            direccionLabel.Text = "direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(125, 201);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(137, 31);
            this.direccionTextBox.TabIndex = 10;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(23, 245);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(86, 23);
            telefonoLabel.TabIndex = 11;
            telefonoLabel.Text = "telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(115, 242);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(147, 31);
            this.telefonoTextBox.TabIndex = 12;
            // 
            // grbUsuario
            // 
            this.grbUsuario.Controls.Add(idUsuarioLabel);
            this.grbUsuario.Controls.Add(this.telefonoTextBox);
            this.grbUsuario.Controls.Add(this.idUsuarioLabel1);
            this.grbUsuario.Controls.Add(telefonoLabel);
            this.grbUsuario.Controls.Add(usuarioLabel);
            this.grbUsuario.Controls.Add(this.direccionTextBox);
            this.grbUsuario.Controls.Add(this.usuarioTextBox);
            this.grbUsuario.Controls.Add(direccionLabel);
            this.grbUsuario.Controls.Add(claveLabel);
            this.grbUsuario.Controls.Add(this.nombreTextBox);
            this.grbUsuario.Controls.Add(this.claveTextBox);
            this.grbUsuario.Controls.Add(nombreLabel);
            this.grbUsuario.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUsuario.Location = new System.Drawing.Point(159, 96);
            this.grbUsuario.Name = "grbUsuario";
            this.grbUsuario.Size = new System.Drawing.Size(453, 284);
            this.grbUsuario.TabIndex = 13;
            this.grbUsuario.TabStop = false;
            this.grbUsuario.Text = "Usuarios";
            // 
            // grbEdicionDocente
            // 
            this.grbEdicionDocente.Controls.Add(this.btnEliminarUsuario);
            this.grbEdicionDocente.Controls.Add(this.btnModificarUsuario);
            this.grbEdicionDocente.Controls.Add(this.btnAgregarUsuario);
            this.grbEdicionDocente.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEdicionDocente.Location = new System.Drawing.Point(151, 496);
            this.grbEdicionDocente.Margin = new System.Windows.Forms.Padding(4);
            this.grbEdicionDocente.Name = "grbEdicionDocente";
            this.grbEdicionDocente.Padding = new System.Windows.Forms.Padding(4);
            this.grbEdicionDocente.Size = new System.Drawing.Size(461, 79);
            this.grbEdicionDocente.TabIndex = 14;
            this.grbEdicionDocente.TabStop = false;
            this.grbEdicionDocente.Text = "Edicion";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(289, 25);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(133, 46);
            this.btnEliminarUsuario.TabIndex = 3;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.Location = new System.Drawing.Point(141, 25);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(140, 46);
            this.btnModificarUsuario.TabIndex = 1;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.Location = new System.Drawing.Point(8, 25);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(125, 46);
            this.btnAgregarUsuario.TabIndex = 0;
            this.btnAgregarUsuario.Text = "Nuevo";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // grbNavegacionUsuario
            // 
            this.grbNavegacionUsuario.Controls.Add(this.lblRegistrosUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnUltimoUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnSiguienteUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnAnteriorUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnPrimeroUsuario);
            this.grbNavegacionUsuario.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNavegacionUsuario.Location = new System.Drawing.Point(207, 387);
            this.grbNavegacionUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.grbNavegacionUsuario.Name = "grbNavegacionUsuario";
            this.grbNavegacionUsuario.Padding = new System.Windows.Forms.Padding(4);
            this.grbNavegacionUsuario.Size = new System.Drawing.Size(314, 101);
            this.grbNavegacionUsuario.TabIndex = 15;
            this.grbNavegacionUsuario.TabStop = false;
            this.grbNavegacionUsuario.Text = "Navegacion";
            // 
            // lblRegistrosUsuario
            // 
            this.lblRegistrosUsuario.AutoSize = true;
            this.lblRegistrosUsuario.Location = new System.Drawing.Point(112, 44);
            this.lblRegistrosUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrosUsuario.Name = "lblRegistrosUsuario";
            this.lblRegistrosUsuario.Size = new System.Drawing.Size(60, 23);
            this.lblRegistrosUsuario.TabIndex = 10;
            this.lblRegistrosUsuario.Text = "x de n";
            // 
            // btnUltimoUsuario
            // 
            this.btnUltimoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoUsuario.Location = new System.Drawing.Point(233, 32);
            this.btnUltimoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimoUsuario.Name = "btnUltimoUsuario";
            this.btnUltimoUsuario.Size = new System.Drawing.Size(44, 46);
            this.btnUltimoUsuario.TabIndex = 3;
            this.btnUltimoUsuario.Text = ">|";
            this.btnUltimoUsuario.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteUsuario
            // 
            this.btnSiguienteUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteUsuario.Location = new System.Drawing.Point(181, 32);
            this.btnSiguienteUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguienteUsuario.Name = "btnSiguienteUsuario";
            this.btnSiguienteUsuario.Size = new System.Drawing.Size(44, 46);
            this.btnSiguienteUsuario.TabIndex = 2;
            this.btnSiguienteUsuario.Text = ">";
            this.btnSiguienteUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorUsuario
            // 
            this.btnAnteriorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorUsuario.Location = new System.Drawing.Point(60, 32);
            this.btnAnteriorUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnteriorUsuario.Name = "btnAnteriorUsuario";
            this.btnAnteriorUsuario.Size = new System.Drawing.Size(44, 46);
            this.btnAnteriorUsuario.TabIndex = 1;
            this.btnAnteriorUsuario.Text = "<";
            this.btnAnteriorUsuario.UseVisualStyleBackColor = true;
            // 
            // btnPrimeroUsuario
            // 
            this.btnPrimeroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroUsuario.Location = new System.Drawing.Point(8, 32);
            this.btnPrimeroUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimeroUsuario.Name = "btnPrimeroUsuario";
            this.btnPrimeroUsuario.Size = new System.Drawing.Size(44, 46);
            this.btnPrimeroUsuario.TabIndex = 0;
            this.btnPrimeroUsuario.Text = "|<";
            this.btnPrimeroUsuario.UseVisualStyleBackColor = true;
            // 
            // Titulo
            // 
            this.Titulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "idUsuario", true));
            this.Titulo.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(244, 19);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(303, 36);
            this.Titulo.TabIndex = 13;
            this.Titulo.Text = "Registro de usuarios.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 617);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.grbNavegacionUsuario);
            this.Controls.Add(this.grbEdicionDocente);
            this.Controls.Add(this.grbUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_parcialllDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.grbUsuario.ResumeLayout(false);
            this.grbUsuario.PerformLayout();
            this.grbEdicionDocente.ResumeLayout(false);
            this.grbNavegacionUsuario.ResumeLayout(false);
            this.grbNavegacionUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private db_parcialllDataSet db_parcialllDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private db_parcialllDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private db_parcialllDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idUsuarioLabel1;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.GroupBox grbUsuario;
        private System.Windows.Forms.GroupBox grbEdicionDocente;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.GroupBox grbNavegacionUsuario;
        private System.Windows.Forms.Label lblRegistrosUsuario;
        private System.Windows.Forms.Button btnUltimoUsuario;
        private System.Windows.Forms.Button btnSiguienteUsuario;
        private System.Windows.Forms.Button btnAnteriorUsuario;
        private System.Windows.Forms.Button btnPrimeroUsuario;
        private System.Windows.Forms.Label Titulo;
    }
}

