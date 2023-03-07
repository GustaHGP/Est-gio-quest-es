using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Class1
    {
        public string Balanço()
        {
            double total;
            string concat="";
            int percent;
            double[] dinheiro = new double[5];
            string []estado = new string[5];
            dinheiro[0] = 67836.43;
            dinheiro[1] = 36678.66;
            dinheiro[2] = 29229.88;
            dinheiro[3] = 27165.48;
            dinheiro[4] = 19849.53;
            estado[0] =  "SP" ;
            estado[1] = "RJ";
            estado[2] = "MG";
            estado[3] = "ES";
            estado[4] = "Outros";
            total = ((((dinheiro[0] + dinheiro[1]) + dinheiro[2]) + dinheiro[3]) + dinheiro[4]);
            for (int i = 0; i < 5; i++)
            {
                concat += "" + estado[i] + "-" + ((dinheiro[i] / total) * 100)+"\n";
            }
            return concat;
        }
    }
}
