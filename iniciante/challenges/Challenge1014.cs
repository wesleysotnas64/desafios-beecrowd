using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1014 : BaseChallenge
    {
        public override void Execute()
        {
            int quilometros;
            double combustivel, consumo;
            quilometros = int.Parse(Console.ReadLine());
            combustivel = double.Parse(Console.ReadLine());
            consumo = quilometros/combustivel;
            Console.WriteLine($"{consumo:F3} km/l");
        }
    }
}