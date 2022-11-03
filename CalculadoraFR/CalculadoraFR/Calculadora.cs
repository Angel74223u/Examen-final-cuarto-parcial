using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFR
{
    public partial class Form1 : Form
    {
        double primero;
            double segundo;
            string operador;

        public Form1()
        {
            InitializeComponent();
        }

        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultiplicacion obj3 = new Clases.ClsMultiplicacion();
        Clases.ClsDivision obj4 = new Clases.ClsDivision();
        private double primero;
        private string operador;
        private double segundo;

        private void button7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0"; 
        }

        private void btN1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void btN3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void btN4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void btN5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void btN7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void btN8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void btN9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void btPunto_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            var operador = "+";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btMenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btPor_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btEntre_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxScreen.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+";
                    Sum = obj.Sumar((primero), (segundo));
                    tbxScreen.Text = Sum.ToString();
                    break;

            }
        }
    }
}
