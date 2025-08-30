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
            this.lblSerie = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblTipica = new System.Windows.Forms.Label();
            this.lblArmonica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(54, 81);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(64, 27);
            this.lblSerie.TabIndex = 0;
            this.lblSerie.Text = "Serie:";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(124, 86);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(281, 22);
            this.txtSerie.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(124, 286);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(281, 61);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(54, 128);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(77, 27);
            this.lblMedia.TabIndex = 3;
            this.lblMedia.Text = "Media:";
            // 
            // lblTipica
            // 
            this.lblTipica.AutoSize = true;
            this.lblTipica.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipica.Location = new System.Drawing.Point(54, 170);
            this.lblTipica.Name = "lblTipica";
            this.lblTipica.Size = new System.Drawing.Size(76, 27);
            this.lblTipica.TabIndex = 4;
            this.lblTipica.Text = "Tipica:";
            // 
            // lblArmonica
            // 
            this.lblArmonica.AutoSize = true;
            this.lblArmonica.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmonica.Location = new System.Drawing.Point(54, 212);
            this.lblArmonica.Name = "lblArmonica";
            this.lblArmonica.Size = new System.Drawing.Size(108, 27);
            this.lblArmonica.TabIndex = 5;
            this.lblArmonica.Text = "Armonica:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 412);
            this.Controls.Add(this.lblArmonica);
            this.Controls.Add(this.lblTipica);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblSerie);
            this.Name = "Form1";
            this.Text = "Estadistica";
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblTipica;
        private System.Windows.Forms.Label lblArmonica;
    }
}

