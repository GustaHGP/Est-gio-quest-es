using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercício_2_estágio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 fibo = new Class1();
            decimal[] fibonacci= new decimal[10];
            string textbox = textBox1.Text;
            decimal x = 0;
            decimal y = 1;
            int i = 0;
            decimal text=15;
            int cont=0;
            label2.Text = "";
            while (i < fibonacci.Length)
            {
                if (i == 0)
                {
                    fibonacci[i] = x;
                }
                else if (i == 1)
                {
                    fibonacci[i] = y;
                }
                else
                {
                    fibonacci[i] = (fibonacci[(i-1)]+fibonacci[(i-2)]);
                }
                label2.Text += "" + fibonacci[i] + ",";
                i++;
            }
            text = Convert.ToDecimal(textbox);
            if (-1 < Convert.ToDecimal(textbox))
            {
                label3.Text = "" + fibo.Pertence(fibonacci, text);
            }
            else
            {
                MessageBox.Show("Digite um positivos:");
            }
        }
    }

}
    
