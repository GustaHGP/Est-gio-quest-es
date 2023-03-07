using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_2_estágio
{
    internal class Class1
    {

        public string Pertence(decimal[] x, decimal y)
        {
            int verif = 0;
            string ret = "";
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == y)
                {
                    ret = "Pertence a sequencia Fibonacci";
                    verif++;
                    break;
                }
                else
                {
                    ret = " ";
                }
                if ((ret == " ")&&(verif==0))
                {
                    ret = "Não pertence a sequencia Fibonacci";

                }
            }
            return ret;
        }
    }

}
