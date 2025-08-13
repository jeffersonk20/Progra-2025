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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.grbOpciones = new System.Windows.Forms.GroupBox();
            this.optDivision = new System.Windows.Forms.RadioButton();
            this.optMultiplicacion = new System.Windows.Forms.RadioButton();
            this.optResta = new System.Windows.Forms.RadioButton();
            this.optSuma = new System.Windows.Forms.RadioButton();
            this.optExponente = new System.Windows.Forms.RadioButton();
            this.optPorcentaje = new System.Windows.Forms.RadioButton();
            this.optFactorial = new System.Windows.Forms.RadioButton();
            this.cboOpciones = new System.Windows.Forms.ComboBox();
            this.btnCalcularOpciones = new System.Windows.Forms.Button();
            this.grbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(272, 116);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 22);
            this.txtNum1.TabIndex = 0;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(207, 122);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(48, 16);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "Num 1:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(223, 269);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(176, 61);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(272, 159);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 22);
            this.txtNum2.TabIndex = 0;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(207, 164);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(48, 16);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Num 2:";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(220, 221);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(152, 29);
            this.lblRespuesta.TabIndex = 3;
            this.lblRespuesta.Text = "Respuesta: ?";
            // 
            // grbOpciones
            // 
            this.grbOpciones.Controls.Add(this.optFactorial);
            this.grbOpciones.Controls.Add(this.optPorcentaje);
            this.grbOpciones.Controls.Add(this.optExponente);
            this.grbOpciones.Controls.Add(this.optDivision);
            this.grbOpciones.Controls.Add(this.optMultiplicacion);
            this.grbOpciones.Controls.Add(this.optResta);
            this.grbOpciones.Controls.Add(this.optSuma);
            this.grbOpciones.Location = new System.Drawing.Point(479, 83);
            this.grbOpciones.Name = "grbOpciones";
            this.grbOpciones.Size = new System.Drawing.Size(221, 268);
            this.grbOpciones.TabIndex = 4;
            this.grbOpciones.TabStop = false;
            this.grbOpciones.Text = "Opciones";
            // 
            // optDivision
            // 
            this.optDivision.AutoSize = true;
            this.optDivision.Location = new System.Drawing.Point(20, 141);
            this.optDivision.Name = "optDivision";
            this.optDivision.Size = new System.Drawing.Size(76, 20);
            this.optDivision.TabIndex = 3;
            this.optDivision.Text = "Division";
            this.optDivision.UseVisualStyleBackColor = true;
            // 
            // optMultiplicacion
            // 
            this.optMultiplicacion.AutoSize = true;
            this.optMultiplicacion.Location = new System.Drawing.Point(20, 105);
            this.optMultiplicacion.Name = "optMultiplicacion";
            this.optMultiplicacion.Size = new System.Drawing.Size(109, 20);
            this.optMultiplicacion.TabIndex = 2;
            this.optMultiplicacion.Text = "Multiplicacion";
            this.optMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // optResta
            // 
            this.optResta.AutoSize = true;
            this.optResta.Location = new System.Drawing.Point(20, 66);
            this.optResta.Name = "optResta";
            this.optResta.Size = new System.Drawing.Size(64, 20);
            this.optResta.TabIndex = 1;
            this.optResta.Text = "Resta";
            this.optResta.UseVisualStyleBackColor = true;
            // 
            // optSuma
            // 
            this.optSuma.AutoSize = true;
            this.optSuma.Checked = true;
            this.optSuma.Location = new System.Drawing.Point(20, 31);
            this.optSuma.Name = "optSuma";
            this.optSuma.Size = new System.Drawing.Size(63, 20);
            this.optSuma.TabIndex = 0;
            this.optSuma.TabStop = true;
            this.optSuma.Text = "Suma";
            this.optSuma.UseVisualStyleBackColor = true;
            // 
            // optExponente
            // 
            this.optExponente.AutoSize = true;
            this.optExponente.Location = new System.Drawing.Point(20, 173);
            this.optExponente.Name = "optExponente";
            this.optExponente.Size = new System.Drawing.Size(92, 20);
            this.optExponente.TabIndex = 4;
            this.optExponente.Text = "Exponente";
            this.optExponente.UseVisualStyleBackColor = true;
            // 
            // optPorcentaje
            // 
            this.optPorcentaje.AutoSize = true;
            this.optPorcentaje.Location = new System.Drawing.Point(20, 206);
            this.optPorcentaje.Name = "optPorcentaje";
            this.optPorcentaje.Size = new System.Drawing.Size(93, 20);
            this.optPorcentaje.TabIndex = 5;
            this.optPorcentaje.Text = "Porcentaje";
            this.optPorcentaje.UseVisualStyleBackColor = true;
            // 
            // optFactorial
            // 
            this.optFactorial.AutoSize = true;
            this.optFactorial.Location = new System.Drawing.Point(19, 242);
            this.optFactorial.Name = "optFactorial";
            this.optFactorial.Size = new System.Drawing.Size(80, 20);
            this.optFactorial.TabIndex = 6;
            this.optFactorial.Text = "Factorial";
            this.optFactorial.UseVisualStyleBackColor = true;
            // 
            // cboOpciones
            // 
            this.cboOpciones.FormattingEnabled = true;
            this.cboOpciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division",
            "Exponente",
            "Porcentaje",
            "Factorial"});
            this.cboOpciones.Location = new System.Drawing.Point(732, 94);
            this.cboOpciones.Name = "cboOpciones";
            this.cboOpciones.Size = new System.Drawing.Size(188, 24);
            this.cboOpciones.TabIndex = 5;
            // 
            // btnCalcularOpciones
            // 
            this.btnCalcularOpciones.Location = new System.Drawing.Point(744, 140);
            this.btnCalcularOpciones.Name = "btnCalcularOpciones";
            this.btnCalcularOpciones.Size = new System.Drawing.Size(160, 52);
            this.btnCalcularOpciones.TabIndex = 6;
            this.btnCalcularOpciones.Text = "Calcular";
            this.btnCalcularOpciones.UseVisualStyleBackColor = true;
            this.btnCalcularOpciones.Click += new System.EventHandler(this.btnCalcularOpciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 450);
            this.Controls.Add(this.btnCalcularOpciones);
            this.Controls.Add(this.cboOpciones);
            this.Controls.Add(this.grbOpciones);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbOpciones.ResumeLayout(false);
            this.grbOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.GroupBox grbOpciones;
        private System.Windows.Forms.RadioButton optDivision;
        private System.Windows.Forms.RadioButton optMultiplicacion;
        private System.Windows.Forms.RadioButton optResta;
        private System.Windows.Forms.RadioButton optSuma;
        private System.Windows.Forms.RadioButton optExponente;
        private System.Windows.Forms.RadioButton optPorcentaje;
        private System.Windows.Forms.RadioButton optFactorial;
        private System.Windows.Forms.ComboBox cboOpciones;
        private System.Windows.Forms.Button btnCalcularOpciones;
    }
}

