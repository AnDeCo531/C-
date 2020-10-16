using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Bucles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] tabla = { 11, 22, 33, 44 };
            //int numero;
            labelr.Text = "";
            //for (int i = 0; i < 4; i++)
            //{
            //    numero = tabla[i];
            //    label1.Text += numero + " - ";
            // }
            foreach (int numero2 in tabla)
            {
                labelr.Text += numero2 + " - ";
            }
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(textBoxnumero1.Text);
            int n2 = Int32.Parse(textBoxnumero2.Text);
            int res = n1 + n2;
            labelr.Text = "La suma es " + res;
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(textBoxnumero1.Text);
            int n2 = Int32.Parse(textBoxnumero2.Text);
            int res = n1 - n2;
            labelr.Text = "La resta es " + res;
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(textBoxnumero1.Text);
            int n2 = Int32.Parse(textBoxnumero2.Text);
            int res = n1 * n2;
            labelr.Text = "El resultado de la multiplicación es " + res;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(textBoxnumero1.Text);
            int n2 = Int32.Parse(textBoxnumero2.Text);
            int res = n1 / n2;
            labelr.Text = "El resultado de la división es " + res;

        }

        private void buttonResto_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(textBoxnumero1.Text);
            int n2 = Int32.Parse(textBoxnumero2.Text);
            int res = n1 % n2;
            labelr.Text = "El resto es " + res;
        }
    } }
