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
            //Declaracion de variables
            double num1, num2, respuesta=0;
            num1 = double.Parse( txtNum1.Text);
            num2 = double.Parse( txtNum2.Text);

            //Suma
            if (optSuma.Checked)
            {
                respuesta = num1 + num2;
            }


            //Resta
            if (optResta.Checked)
            {
                respuesta = num1 - num2;
            }


            //Multiplicacion
            if (optMultiplicacion.Checked)
            {
                respuesta = num1 * num2;
            }


            //Division
            if (optDivision.Checked)
            {
                respuesta = num1 / num2;
            }

            //Exponenciacion
            if (optExponente.Checked)
            { 
                respuesta = Math.Pow(num1, num2);
            }

            //Porcentaje
            if (optPorcentaje.Checked)
            {
                respuesta = (num1 * num2) / 100;
            }

            //Factorial 5! 5x4x3x2x1=120 
           


            //Modulo


            //Mostrar resultado
            lblRespuesta.Text = " Respuesta "  +  respuesta;
        }

        private void btnCalcularOpciones_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text); // Asignar valor a num2

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
                    respuesta = num1 / num2;
                    break;

            }
            lblRespuesta.Text = " Respuesta " + respuesta;
        }
       

    }
}

