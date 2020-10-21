using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba_Libreria;

namespace Componente_Calculadora
{
    public partial class Calculadora : UserControl
    {
        double numero1, numero2, resultado;
        bool banderaNumero1 = false;
        bool banderaOperacion = false;
        string operacionSeleccionada;
        public Calculadora()
        {
            InitializeComponent();
        }
        private double Operacion(string operacion)
        {
            double resultado = 0.0;
            switch (operacion)

            {
                case "suma":
                    resultado = Operaciones.suma(numero1, numero2);
                    break;
                case "resta":
                    resultado = Operaciones.resta(numero1, numero2);
                    break;
                case "division":
                    resultado = Operaciones.multiplicacion(numero1, numero2);
                    break;
                case "multiplicacion":
                    resultado = Operaciones.division(numero1, numero2);
                    break;

            }
            return resultado;
        }

        private void boton0_Click(object sender, EventArgs e)
        {

            textBoxPantalla.Text = textBoxPantalla.Text + "0";
            banderaNumero1 = true;
        }

        private void boton1_Click(object sender, EventArgs e)
        {

            textBoxPantalla.Text = textBoxPantalla.Text + "1";
            banderaNumero1 = true;
        }

        private void boton2_Click(object sender, EventArgs e)
        {

            textBoxPantalla.Text = textBoxPantalla.Text + "2";
            banderaNumero1 = true;
        }

        private void boton3_Click(object sender, EventArgs e)
        {

            textBoxPantalla.Text = textBoxPantalla.Text + "3";
            banderaNumero1 = true;
        }

        private void boton4_Click(object sender, EventArgs e)
        {

            textBoxPantalla.Text = textBoxPantalla.Text + "4";
            banderaNumero1 = true;
        }

        private void boton5_Click(object sender, EventArgs e)
        {

            textBoxPantalla.Text = textBoxPantalla.Text + "5";
            banderaNumero1 = true;
        }

        private void boton6_Click(object sender, EventArgs e)
        {

            textBoxPantalla.Text = textBoxPantalla.Text + "6";
            banderaNumero1 = true;
        }

        private void boton7_Click(object sender, EventArgs e)
        {

            textBoxPantalla.Text = textBoxPantalla.Text + "7";
            banderaNumero1 = true;
        }

        private void boton8_Click(object sender, EventArgs e)
        {

            textBoxPantalla.Text = textBoxPantalla.Text + "8";
            banderaNumero1 = true;
        }

        private void boton9_Click(object sender, EventArgs e)
        {

            textBoxPantalla.Text = textBoxPantalla.Text + "9";
            banderaNumero1 = true;
        }

        private void botonSuma_Click(object sender, EventArgs e)
        {
            if (banderaNumero1 && !banderaOperacion)
            {
                numero1 = Convert.ToDouble(textBoxPantalla.Text);
                limpiar();
                banderaNumero1 = true;
                banderaOperacion = true;
                operacionSeleccionada = "suma";

            }
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            if (banderaNumero1 && !banderaOperacion)
            {
                numero1 = Convert.ToDouble(textBoxPantalla.Text);
                limpiar();
                banderaNumero1 = true;
                banderaOperacion = true;
                operacionSeleccionada = "resta";

            }
        }

        private void botonMult_Click(object sender, EventArgs e)
        {
            if (banderaNumero1 && !banderaOperacion)
            {
                numero1 = Convert.ToDouble(textBoxPantalla.Text);
                limpiar();
                banderaNumero1 = true;
                banderaOperacion = true;
                operacionSeleccionada = "multiplicacion";

            }
        }

        private void botonDiv_Click(object sender, EventArgs e)
        {
            if (banderaNumero1 && !banderaOperacion)
            {
                numero1 = Convert.ToDouble(textBoxPantalla.Text);
                limpiar();
                banderaNumero1 = true;
                banderaOperacion = true;
                operacionSeleccionada = "division";

            }
        }

        private void botonClear_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void botonResultado_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(textBoxPantalla.Text);

            resultado = Operacion(operacionSeleccionada);
            textBoxPantalla.Text = resultado.ToString();
        }
        private void limpiar()
        {
            banderaNumero1 = false;
            banderaOperacion = false;
            textBoxPantalla.Text = " ";
        }
    }
}
