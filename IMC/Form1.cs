using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           // Criação das variaveis e o calculo do IMC
            double peso = double.Parse(txbPeso.Text.ToString());
            double altura = Math.Pow(double.Parse(txtAltura.Text), 2);
            double imc =  peso / altura;
            txtResul.Text= imc.ToString("F2");
            // Verificar classificação
            if (imc <=18.5) {
                txtResultado.Text = "Abaixo do peso!";
            }
            else if (imc <= 24.9)
            {
                txtResultado.Text = "Peso ideal";
            }
            else if (imc <= 29.9) {

                txtResultado.Text = "Levemente Acima do peso";
            }
            else if(imc <= 34.9)
            {
                txtResultado.Text = "Obesidade grau 1";
            }
            else if (imc >= 39.9)
            {
                txtResultado.Text = "Obesidade grau 2";
            }
            else
            {
                txtResultado.Text = "Obesidade grau 3";
            }
            
        }
    }
}
