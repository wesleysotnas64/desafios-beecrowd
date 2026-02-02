using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1035 : BaseChallenge
    {
        public override void Execute()
        {
            int a, b, c, d;
            bool BMaiorQueC, DMaiorQueA, somaCDMaiorQueSomaAB, CeDPositivos, AehPar;
            string[] valores = Console.ReadLine().Split(' ');
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            c = int.Parse(valores[2]);
            d = int.Parse(valores[3]);

            BMaiorQueC = b>c;
            DMaiorQueA = d>a;
            somaCDMaiorQueSomaAB = (c+d)>(a+b);
            CeDPositivos = c>0&d>0;
            AehPar = a%2==0;

            if(
                BMaiorQueC &&
                DMaiorQueA &&
                somaCDMaiorQueSomaAB &&
                CeDPositivos &&
                AehPar
            )
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}