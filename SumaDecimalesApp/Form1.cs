using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaDecimalesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los números ingresados por el usuario
                decimal numero1 = decimal.Parse(txtNumero1.Text, CultureInfo.InvariantCulture);
                decimal numero2 = decimal.Parse(txtNumero2.Text, CultureInfo.InvariantCulture);

                // Calcular la suma sin redondear
                decimal suma = numero1 + numero2;

                // Mostrar la suma en el cuadro de texto de resultado sin redondear
                lblResultado.Text = suma.ToString("0.#############################", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números decimales válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los números ingresados por el usuario
                decimal numero1 = decimal.Parse(txtNumero1.Text, CultureInfo.InvariantCulture);
                decimal numero2 = decimal.Parse(txtNumero2.Text, CultureInfo.InvariantCulture);

                // Calcular la suma sin redondear
                decimal resta = numero1 - numero2;

                // Mostrar la suma en el cuadro de texto de resultado sin redondear
                lblResultado.Text = resta.ToString("0.#############################", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números decimales válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los números ingresados por el usuario
                decimal numero1 = decimal.Parse(txtNumero1.Text, CultureInfo.InvariantCulture);
                decimal numero2 = decimal.Parse(txtNumero2.Text, CultureInfo.InvariantCulture);

                // Calcular la suma sin redondear
                decimal division = numero1 / numero2;

                // Mostrar la suma en el cuadro de texto de resultado sin redondear
                lblResultado.Text = division.ToString("0.#############################", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números decimales válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
        }
    }
}
