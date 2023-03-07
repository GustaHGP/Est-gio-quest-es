using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            char[] otxet1 = new char[texto.Length];
            string otxet="";
            for (int i = (texto.Length-1); i >= 0 ; i--)
            {
                otxet+=texto[i];

            }
            label1.Text = "" + otxet + "";
          
        }
    }
}
