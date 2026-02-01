using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1017 : BaseChallenge
    {
        public override void Execute()
        {
            int dt = int.Parse(Console.ReadLine());
            int vm = int.Parse(Console.ReadLine());
            double ds = vm*dt;
            double litros = ds/12.0;
            Console.WriteLine($"{litros:F3}");
        }
    }
}