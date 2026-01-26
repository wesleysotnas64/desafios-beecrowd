using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1001 : BaseChallenge
    {
        public override void Execute()
        {
            int a, b, x;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            x = a+b;
            Console.WriteLine($"X = {x}");
        }
    }
}