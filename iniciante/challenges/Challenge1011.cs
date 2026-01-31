using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1011 : BaseChallenge
    {
        public override void Execute()
        {
            double raio, area;
            double pi = 3.14159;
            raio = double.Parse(Console.ReadLine());
            area = (4.0/3.0)*pi*Math.Pow(raio, 3);
            Console.WriteLine($"VOLUME = {area:F3}");
        }
    }
}