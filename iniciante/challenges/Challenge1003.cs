using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1003 : BaseChallenge
    {
        public override void Execute()
        {
            int a, b, SOMA;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            SOMA = a + b;
            Console.WriteLine($"SOMA = {SOMA}");
        }
    }
}