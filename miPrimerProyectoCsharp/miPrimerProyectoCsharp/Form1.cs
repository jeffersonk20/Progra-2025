using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyectoCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2 = 0, respuesta = 0;
            bool esNum1Valido = double.TryParse(txtNum1.Text, out num1);
            bool esNum2Valido = double.TryParse(txtNum2.Text, out num2);

            if (!esNum1Valido)
            {
                lblRespuesta.Text = "Error: Número 1 inválido.";
                return;
            }

            // Suma
            if (optSuma.Checked)
            {
                if (!esNum2Valido)
                {
                    lblRespuesta.Text = "Error: Número 2 inválido.";
                    return;
                }
                respuesta = num1 + num2;
            }

            // Resta
             if (optResta.Checked)
            {
                if (!esNum2Valido)
                {
                    lblRespuesta.Text = "Error: Número 2 inválido.";
                    return;
                }
                respuesta = num1 - num2;
            }

            // Multiplicación
            else if (optMultiplicacion.Checked)
            {
                if (!esNum2Valido)
                {
                    lblRespuesta.Text = "Error: Número 2 inválido.";
                    return;
                }
                respuesta = num1 * num2;
            }

            // División
            else if (optDivision.Checked)
            {
                if (!esNum2Valido)
                {
                    lblRespuesta.Text = "Error: Número 2 inválido.";
                    return;
                }
                if (num2 == 0)
                {
                    lblRespuesta.Text = "Error: División por cero.";
                    return;
                }
                respuesta = num1 / num2;
            }

            // Exponenciación
            else if (optExponente.Checked)
            {
                if (!esNum2Valido)
                {
                    lblRespuesta.Text = "Error: Número 2 inválido.";
                    return;
                }
                respuesta = Math.Pow(num1, num2);
            }

            // Porcentaje
            else if (optPorcentaje.Checked)
            {
                if (!esNum2Valido)
                {
                    lblRespuesta.Text = "Error: Número 2 inválido.";
                    return;
                }
                respuesta = (num1 * num2) / 100;
            }

            // Factorial
            else if (optFactorial.Checked)
            {
                if (num1 < 0 || num1 != (int)num1)
                {
                    lblRespuesta.Text = "Error: El factorial solo acepta enteros positivos.";
                    return;
                }
                int factorial = 1;
                for (int i = 1; i <= (int)num1; i++)
                {
                    factorial *= i;
                }
                respuesta = factorial;
            }

             // Módulo
             else if (optModulo.Checked)
            {
                if (!esNum2Valido)
                {
                    lblRespuesta.Text = "Error: Número 2 inválido.";
                    return;
                }
                if (num2 == 0)
                {
                    lblRespuesta.Text = "Error: División por cero.";
                    return;
                }
                respuesta = num1 % num2;
            }

            lblRespuesta.Text = "Respuesta: " + respuesta;
        }

        private void btnCalcularOpciones_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            bool esNum1Valido = double.TryParse(txtNum1.Text, out num1);
            bool esNum2Valido = double.TryParse(txtNum2.Text, out num2);

            if (!esNum1Valido)
            {
                lblRespuesta.Text = "Error: Número 1 inválido.";
                return;
            }
            if (!esNum2Valido && cboOpciones.SelectedIndex != 6)
            {
                lblRespuesta.Text = "Error: Número 2 inválido.";
                return;
            }

            switch (cboOpciones.SelectedIndex)
            {
                case 0:
                    respuesta = num1 + num2;
                    break;
                case 1:
                    respuesta = num1 - num2;
                    break;
                case 2:
                    respuesta = num1 * num2;
                    break;
                case 3:
                    if (num2 == 0)
                    {
                        lblRespuesta.Text = "Error: División por cero.";
                        return;
                    }
                    respuesta = num1 / num2;
                    break;
                case 4:
                    respuesta = Math.Pow(num1, num2);
                    break;
                case 5:
                    respuesta = (num1 * num2) / 100;
                    break;
                case 6:
                    if (num1 < 0 || num1 != (int)num1)
                    {
                        lblRespuesta.Text = "Error: El factorial solo acepta enteros positivos.";
                        return;
                    }
                    int factorial = 1;
                    for (int i = 1; i <= (int)num1; i++)
                    {
                        factorial *= i;
                    }
                    respuesta = factorial;
                    break;
                case 7:
                    if (num2 == 0)
                    {
                        lblRespuesta.Text = "Error: División por cero.";
                        return;
                    }
                    respuesta = num1 % num2;
                    break;
            }
            lblRespuesta.Text = " Respuesta " + respuesta;
        }
       

    }
}

