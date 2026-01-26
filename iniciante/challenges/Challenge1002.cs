using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1002 : BaseChallenge
    {
        public override void Execute()
        {
            double raio = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            double pi = 3.14159; 
            double area = pi * Math.Pow(raio, 2);
            Console.WriteLine("A=" + area.ToString("F4", System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}