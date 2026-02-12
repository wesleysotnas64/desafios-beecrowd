using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1045 : BaseChallenge
    {
        public override void Execute()
        {
            string[] valores = Console.ReadLine().Split(' ');
            double[] lados =  new double[3];
            for(int i = 0; i < 3; i++)
                lados[i] = double.Parse(valores[i]);
            Ordena(lados);
            double a = lados[0];
            double b = lados[1];
            double c = lados[2];

            if(a >= b+c) Console.WriteLine("NAO FORMA TRIANGULO");
            else
            {
                if(Math.Pow(a,2) == Math.Pow(b,2)+Math.Pow(c,2)) Console.WriteLine("TRIANGULO RETANGULO");
                if(Math.Pow(a,2) > (Math.Pow(b,2)+Math.Pow(c,2))) Console.WriteLine("TRIANGULO OBTUSANGULO");
                if(Math.Pow(a,2) < Math.Pow(b,2)+Math.Pow(c,2)) Console.WriteLine("TRIANGULO ACUTANGULO");
                if (a == b && b == c) 
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (a == b || b == c || a == c) 
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }


        }

        public static void Ordena(double[] lados)
        {
            int auxIndex;
            double aux;
            for(int i = 1; i < 3; i++)
            {
                auxIndex = i;
                while(auxIndex > 0)
                {
                    if (lados[auxIndex] > lados[auxIndex - 1])
                    {
                        aux = lados[auxIndex - 1];
                        lados[auxIndex - 1] = lados[auxIndex];
                        lados[auxIndex] = aux;
                    }
                    else break;
                    auxIndex--;
                }
            }
        }
    }
}