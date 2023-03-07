using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Class1
    {
        public string analisar()
        {
double maior=0;
double menor=0;
double media=0;
int dayoff = 0;
int superior = 0;
double[] vendas = new double[30] {
22174.1664,24537.6698,26139.6134,0.0, 0.0,26742.6612,0.0,42889.2258,
346251.174,11191.4722,
0.0,0.0,3847.4823,
373.7838,2659.7563,48924.2448,
18419.2614,0.0,0.0,
35240.1826,43829.1667,18235.6852,
4355.0662,13327.1025,0.0
,0.0,25681.8318,
1718.1221,13220.495,8414.61
};

            for (int i = 0; i < vendas.Length; i++)
            {
                if (vendas[i] == 0.0)
                {
                    dayoff++;
                }
                else
                {
                    media = media + vendas[i];

                    if (maior < vendas[i])
                    {
                        menor = maior;
                        maior = vendas[i];

                    }
                    if (menor > vendas[i])
                    {
                        menor = vendas[i];
                    }
                }
            }
            media = (media / (30-dayoff));
            for (int i = 0; i < vendas.Length; i++)
            {
                if (media < vendas[i])
                {
                    superior++;
                }

            }

            return "O maior valor de faturamento no mês foi:R$"+maior+"\n"+
                "O menor valor de faturamento no mês foi:R$"+menor+"\n"+
                "O numero de dias em que o faturamento diário superou a mèdia mensal foi:"+superior+" dias";            }
        }
    }

