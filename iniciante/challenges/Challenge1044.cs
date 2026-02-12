using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1044 : BaseChallenge
    {
        public override void Execute()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            int resto = a>b?a%b:b%a;
            if(resto != 0) Console.WriteLine("Nao sao Multiplos");
            else Console.WriteLine("Sao Multiplos");
        }
    }
}