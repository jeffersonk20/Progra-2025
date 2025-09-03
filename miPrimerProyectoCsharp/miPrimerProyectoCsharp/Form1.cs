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
        //Impuesto sobre la actividad económica

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double[][] impuestos = new double[][]
            {
        new double[]{0.01, 500, 1.5, 0},
        new double[]{500.01, 1000, 1.5, 3},
        new double[]{1000.01, 2000, 3, 3},
        new double[]{2000.01, 3000, 6, 3},
        new double[]{3000.01, 6000, 9, 2},
        new double[]{8000.01, 18000, 15, 2},
        new double[]{18000.01, 30000, 39, 2},
        new double[]{30000.01, 60000, 63, 1},
        new double[]{60000.01, 100000, 93, 0.8},
        new double[]{100000.01, 200000, 125, 0.7},
        new double[]{200000.01, 300000, 195, 0.6},
        new double[]{300000.01, 400000, 255, 0.45},
        new double[]{400000.01, 500000, 300, 0.4},
        new double[]{500000.01, 1000000, 340, 0.3},
        new double[]{1000000.01, 9999999, 490, 0.18},
            };

            double monto_total = double.Parse(txtMonto.Text);
            double respuesta = 0;

            foreach (var tramo in impuestos)
            {
                double desde = tramo[0];
                double hasta = tramo[1];
                double precio = tramo[2];
                double adicional = tramo[3];

                if (monto_total >= desde && monto_total <= hasta)
                {
                    respuesta = ((monto_total - desde) / 1000) * adicional + precio;
                    break;
                }
            }

            lblMontoTotal.Text = "Respuesta: " + respuesta.ToString("N2");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //CONVERSOR DE AREAS (SUPERFICIE)
        String[][] etiquetas = new string[][] {
            new string[]{"Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzanas", "Hectáreas"},//superficie
        };



       
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double[] valores = new double[] { 0.092903, 0.835464, 0.836127, 1, 437.5, 7000, 10000 };

            double cantidad = double.Parse(txtCantidad.Text);

            int de = cboDe.SelectedIndex;
            int a = cboA.SelectedIndex;

            double cantidadEnMetros = cantidad * valores[de];
            double respuesta = cantidadEnMetros / valores[a];

            lblRespuesta.Text = "Respuesta: " + respuesta.ToString("N2");


        }
    } }

    
       