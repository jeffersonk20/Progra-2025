namespace Laboratorio1Progra
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
            this.grbOpciones = new System.Windows.Forms.GroupBox();
            this.optMoneda = new System.Windows.Forms.RadioButton();
            this.optMasa = new System.Windows.Forms.RadioButton();
            this.optAlmacenamiento = new System.Windows.Forms.RadioButton();
            this.optLongitud = new System.Windows.Forms.RadioButton();
            this.optVolumen = new System.Windows.Forms.RadioButton();
            this.optTiempo = new System.Windows.Forms.RadioButton();
            this.lblConversor = new System.Windows.Forms.Label();
            this.cbDe = new System.Windows.Forms.ComboBox();
            this.cbA = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.grbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOpciones
            // 
            this.grbOpciones.Controls.Add(this.optTiempo);
            this.grbOpciones.Controls.Add(this.optVolumen);
            this.grbOpciones.Controls.Add(this.optLongitud);
            this.grbOpciones.Controls.Add(this.optAlmacenamiento);
            this.grbOpciones.Controls.Add(this.optMasa);
            this.grbOpciones.Controls.Add(this.optMoneda);
            this.grbOpciones.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOpciones.Location = new System.Drawing.Point(87, 153);
            this.grbOpciones.Name = "grbOpciones";
            this.grbOpciones.Size = new System.Drawing.Size(276, 380);
            this.grbOpciones.TabIndex = 0;
            this.grbOpciones.TabStop = false;
            this.grbOpciones.Text = "Opciones";
            // 
            // optMoneda
            // 
            this.optMoneda.AutoSize = true;
            this.optMoneda.Location = new System.Drawing.Point(18, 56);
            this.optMoneda.Name = "optMoneda";
            this.optMoneda.Size = new System.Drawing.Size(134, 37);
            this.optMoneda.TabIndex = 1;
            this.optMoneda.TabStop = true;
            this.optMoneda.Text = "Moneda";
            this.optMoneda.UseVisualStyleBackColor = true;
            // 
            // optMasa
            // 
            this.optMasa.AutoSize = true;
            this.optMasa.Location = new System.Drawing.Point(18, 110);
            this.optMasa.Name = "optMasa";
            this.optMasa.Size = new System.Drawing.Size(99, 37);
            this.optMasa.TabIndex = 2;
            this.optMasa.TabStop = true;
            this.optMasa.Text = "Masa";
            this.optMasa.UseVisualStyleBackColor = true;
            // 
            // optAlmacenamiento
            // 
            this.optAlmacenamiento.AutoSize = true;
            this.optAlmacenamiento.Location = new System.Drawing.Point(18, 218);
            this.optAlmacenamiento.Name = "optAlmacenamiento";
            this.optAlmacenamiento.Size = new System.Drawing.Size(239, 37);
            this.optAlmacenamiento.TabIndex = 3;
            this.optAlmacenamiento.TabStop = true;
            this.optAlmacenamiento.Text = "Almacenamiento";
            this.optAlmacenamiento.UseVisualStyleBackColor = true;
            // 
            // optLongitud
            // 
            this.optLongitud.AutoSize = true;
            this.optLongitud.Location = new System.Drawing.Point(18, 164);
            this.optLongitud.Name = "optLongitud";
            this.optLongitud.Size = new System.Drawing.Size(128, 37);
            this.optLongitud.TabIndex = 4;
            this.optLongitud.TabStop = true;
            this.optLongitud.Text = "Logitud";
            this.optLongitud.UseVisualStyleBackColor = true;
            // 
            // optVolumen
            // 
            this.optVolumen.AutoSize = true;
            this.optVolumen.Location = new System.Drawing.Point(18, 269);
            this.optVolumen.Name = "optVolumen";
            this.optVolumen.Size = new System.Drawing.Size(142, 37);
            this.optVolumen.TabIndex = 5;
            this.optVolumen.TabStop = true;
            this.optVolumen.Text = "Volumen";
            this.optVolumen.UseVisualStyleBackColor = true;
            // 
            // optTiempo
            // 
            this.optTiempo.AutoSize = true;
            this.optTiempo.Location = new System.Drawing.Point(16, 318);
            this.optTiempo.Name = "optTiempo";
            this.optTiempo.Size = new System.Drawing.Size(129, 37);
            this.optTiempo.TabIndex = 6;
            this.optTiempo.TabStop = true;
            this.optTiempo.Text = "Tiempo";
            this.optTiempo.UseVisualStyleBackColor = true;
            // 
            // lblConversor
            // 
            this.lblConversor.AutoSize = true;
            this.lblConversor.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversor.Location = new System.Drawing.Point(315, 28);
            this.lblConversor.Name = "lblConversor";
            this.lblConversor.Size = new System.Drawing.Size(246, 47);
            this.lblConversor.TabIndex = 1;
            this.lblConversor.Text = "CONVERSOR";
          
            // 
            // cbDe
            // 
            this.cbDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDe.FormattingEnabled = true;
            this.cbDe.Location = new System.Drawing.Point(509, 174);
            this.cbDe.Name = "cbDe";
            this.cbDe.Size = new System.Drawing.Size(205, 24);
            this.cbDe.TabIndex = 2;
        
            // 
            // cbA
            // 
            this.cbA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbA.FormattingEnabled = true;
            this.cbA.Location = new System.Drawing.Point(509, 243);
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(205, 24);
            this.cbA.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(510, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 22);
            this.textBox1.TabIndex = 4;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRespuesta.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(323, 602);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(164, 35);
            this.lblRespuesta.TabIndex = 5;
            this.lblRespuesta.Text = "Respuesta: ?";
            this.lblRespuesta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "¿Cuánto va a calcular?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "De:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(586, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "A: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConvertir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertir.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConvertir.Location = new System.Drawing.Point(509, 405);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(205, 44);
            this.btnConvertir.TabIndex = 9;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 728);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbA);
            this.Controls.Add(this.cbDe);
            this.Controls.Add(this.lblConversor);
            this.Controls.Add(this.grbOpciones);
            this.Name = "Form1";
            this.Text = "Conversor de unidades";
           
            this.grbOpciones.ResumeLayout(false);
            this.grbOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOpciones;
        private System.Windows.Forms.RadioButton optTiempo;
        private System.Windows.Forms.RadioButton optVolumen;
        private System.Windows.Forms.RadioButton optLongitud;
        private System.Windows.Forms.RadioButton optAlmacenamiento;
        private System.Windows.Forms.RadioButton optMasa;
        private System.Windows.Forms.RadioButton optMoneda;
        private System.Windows.Forms.Label lblConversor;
        private System.Windows.Forms.ComboBox cbDe;
        private System.Windows.Forms.ComboBox cbA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvertir;
    }
}

