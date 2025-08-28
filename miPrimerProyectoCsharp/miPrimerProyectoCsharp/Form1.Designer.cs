namespace miPrimerProyectoCsharp
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
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.lblRespuestaConversor = new System.Windows.Forms.Label();
            this.txtCantidadConversor = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblDeConversor = new System.Windows.Forms.Label();
            this.lblAConversor = new System.Windows.Forms.Label();
            this.lblCantidadConversor = new System.Windows.Forms.Label();
            this.cboTipoConversor = new System.Windows.Forms.ComboBox();
            this.cboAConversor = new System.Windows.Forms.ComboBox();
            this.cboDeConversor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConversor.Location = new System.Drawing.Point(107, 69);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(64, 26);
            this.lblTipoConversor.TabIndex = 0;
            this.lblTipoConversor.Text = "Tipo:";
            // 
            // lblRespuestaConversor
            // 
            this.lblRespuestaConversor.AutoSize = true;
            this.lblRespuestaConversor.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaConversor.Location = new System.Drawing.Point(218, 379);
            this.lblRespuestaConversor.Name = "lblRespuestaConversor";
            this.lblRespuestaConversor.Size = new System.Drawing.Size(140, 26);
            this.lblRespuestaConversor.TabIndex = 5;
            this.lblRespuestaConversor.Text = "Respuesta: ?";
            // 
            // txtCantidadConversor
            // 
            this.txtCantidadConversor.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadConversor.Location = new System.Drawing.Point(223, 276);
            this.txtCantidadConversor.Name = "txtCantidadConversor";
            this.txtCantidadConversor.Size = new System.Drawing.Size(152, 27);
            this.txtCantidadConversor.TabIndex = 6;
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConvertir.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConvertir.Location = new System.Drawing.Point(467, 136);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(166, 63);
            this.btnConvertir.TabIndex = 7;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click_1);
            // 
            // lblDeConversor
            // 
            this.lblDeConversor.AutoSize = true;
            this.lblDeConversor.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeConversor.Location = new System.Drawing.Point(107, 136);
            this.lblDeConversor.Name = "lblDeConversor";
            this.lblDeConversor.Size = new System.Drawing.Size(48, 26);
            this.lblDeConversor.TabIndex = 8;
            this.lblDeConversor.Text = "De:";
            // 
            // lblAConversor
            // 
            this.lblAConversor.AutoSize = true;
            this.lblAConversor.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAConversor.Location = new System.Drawing.Point(107, 206);
            this.lblAConversor.Name = "lblAConversor";
            this.lblAConversor.Size = new System.Drawing.Size(33, 26);
            this.lblAConversor.TabIndex = 9;
            this.lblAConversor.Text = "A:";
            // 
            // lblCantidadConversor
            // 
            this.lblCantidadConversor.AutoSize = true;
            this.lblCantidadConversor.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadConversor.Location = new System.Drawing.Point(107, 277);
            this.lblCantidadConversor.Name = "lblCantidadConversor";
            this.lblCantidadConversor.Size = new System.Drawing.Size(110, 26);
            this.lblCantidadConversor.TabIndex = 10;
            this.lblCantidadConversor.Text = "Cantidad:";
            // 
            // cboTipoConversor
            // 
            this.cboTipoConversor.FormattingEnabled = true;
            this.cboTipoConversor.Items.AddRange(new object[] {
            " Monedas",
            " Longitud",
            " Masa",
            " Volumen",
            " Almacenamiento",
            " Tiempo",
            "Area"});
            this.cboTipoConversor.Location = new System.Drawing.Point(187, 70);
            this.cboTipoConversor.Name = "cboTipoConversor";
            this.cboTipoConversor.Size = new System.Drawing.Size(146, 24);
            this.cboTipoConversor.TabIndex = 11;
            this.cboTipoConversor.SelectedIndexChanged += new System.EventHandler(this.cboTipoConversor_SelectedIndexChanged_1);
            // 
            // cboAConversor
            // 
            this.cboAConversor.FormattingEnabled = true;
            this.cboAConversor.Location = new System.Drawing.Point(146, 206);
            this.cboAConversor.Name = "cboAConversor";
            this.cboAConversor.Size = new System.Drawing.Size(146, 24);
            this.cboAConversor.TabIndex = 12;
            // 
            // cboDeConversor
            // 
            this.cboDeConversor.FormattingEnabled = true;
            this.cboDeConversor.Location = new System.Drawing.Point(161, 136);
            this.cboDeConversor.Name = "cboDeConversor";
            this.cboDeConversor.Size = new System.Drawing.Size(146, 24);
            this.cboDeConversor.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 508);
            this.Controls.Add(this.cboDeConversor);
            this.Controls.Add(this.cboAConversor);
            this.Controls.Add(this.cboTipoConversor);
            this.Controls.Add(this.lblCantidadConversor);
            this.Controls.Add(this.lblAConversor);
            this.Controls.Add(this.lblDeConversor);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtCantidadConversor);
            this.Controls.Add(this.lblRespuestaConversor);
            this.Controls.Add(this.lblTipoConversor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoConversor;
        private System.Windows.Forms.Label lblRespuestaConversor;
        private System.Windows.Forms.TextBox txtCantidadConversor;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblDeConversor;
        private System.Windows.Forms.Label lblAConversor;
        private System.Windows.Forms.Label lblCantidadConversor;
        private System.Windows.Forms.ComboBox cboTipoConversor;
        private System.Windows.Forms.ComboBox cboAConversor;
        private System.Windows.Forms.ComboBox cboDeConversor;
    }
}

