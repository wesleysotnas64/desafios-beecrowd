using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1013 : BaseChallenge
    {
        public override void Execute()
        {
            int a, b, c;
            string[] valores = Console.ReadLine().Split(' ');
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            c = int.Parse(valores[2]);
            int maior = MaiorAB(a,b);
            maior = MaiorAB(maior, c);
            Console.WriteLine($"{maior} eh o maior");
        }

        public static int MaiorAB(int a, int b)
        {
            return (a+b+Math.Abs(a-b))/2;
        }
    }
}