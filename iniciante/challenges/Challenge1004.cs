using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1004 : BaseChallenge
    {
        public override void Execute()
        {
            int a, b, PROD;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            PROD = a * b;
            Console.WriteLine($"PROD = {PROD}");
        }
    }
}