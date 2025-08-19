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
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblIsss = new System.Windows.Forms.Label();
            this.lblAfp = new System.Windows.Forms.Label();
            this.lblIsr = new System.Windows.Forms.Label();
            this.lblDeducciones = new System.Windows.Forms.Label();
            this.lblSueldoneto = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(107, 69);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(86, 26);
            this.lblSueldo.TabIndex = 0;
            this.lblSueldo.Text = "Sueldo:";
            // 
            // lblIsss
            // 
            this.lblIsss.AutoSize = true;
            this.lblIsss.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsss.Location = new System.Drawing.Point(107, 119);
            this.lblIsss.Name = "lblIsss";
            this.lblIsss.Size = new System.Drawing.Size(88, 26);
            this.lblIsss.TabIndex = 1;
            this.lblIsss.Text = "ISSS: ?";
            // 
            // lblAfp
            // 
            this.lblAfp.AutoSize = true;
            this.lblAfp.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfp.Location = new System.Drawing.Point(107, 170);
            this.lblAfp.Name = "lblAfp";
            this.lblAfp.Size = new System.Drawing.Size(82, 26);
            this.lblAfp.TabIndex = 2;
            this.lblAfp.Text = "AFP: ?";
            // 
            // lblIsr
            // 
            this.lblIsr.AutoSize = true;
            this.lblIsr.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsr.Location = new System.Drawing.Point(107, 221);
            this.lblIsr.Name = "lblIsr";
            this.lblIsr.Size = new System.Drawing.Size(78, 26);
            this.lblIsr.TabIndex = 3;
            this.lblIsr.Text = "ISR: ?";
            // 
            // lblDeducciones
            // 
            this.lblDeducciones.AutoSize = true;
            this.lblDeducciones.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeducciones.Location = new System.Drawing.Point(107, 278);
            this.lblDeducciones.Name = "lblDeducciones";
            this.lblDeducciones.Size = new System.Drawing.Size(223, 26);
            this.lblDeducciones.TabIndex = 4;
            this.lblDeducciones.Text = "Total Deducciones: ?";
            // 
            // lblSueldoneto
            // 
            this.lblSueldoneto.AutoSize = true;
            this.lblSueldoneto.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoneto.Location = new System.Drawing.Point(107, 342);
            this.lblSueldoneto.Name = "lblSueldoneto";
            this.lblSueldoneto.Size = new System.Drawing.Size(156, 26);
            this.lblSueldoneto.TabIndex = 5;
            this.lblSueldoneto.Text = "Sueldo Neto: ?";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.Location = new System.Drawing.Point(210, 69);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 27);
            this.txtSueldo.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcular.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Location = new System.Drawing.Point(357, 56);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(166, 63);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.lblSueldoneto);
            this.Controls.Add(this.lblDeducciones);
            this.Controls.Add(this.lblIsr);
            this.Controls.Add(this.lblAfp);
            this.Controls.Add(this.lblIsss);
            this.Controls.Add(this.lblSueldo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblIsss;
        private System.Windows.Forms.Label lblAfp;
        private System.Windows.Forms.Label lblIsr;
        private System.Windows.Forms.Label lblDeducciones;
        private System.Windows.Forms.Label lblSueldoneto;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Button btnCalcular;
    }
}

