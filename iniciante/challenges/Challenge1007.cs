using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1007 : BaseChallenge
    {
        public override void Execute()
        {
            int a, b, c, d, diferenca;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            diferenca = (a*b) - (c*d);
            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}