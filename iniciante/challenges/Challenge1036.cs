using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1036 : BaseChallenge
    {
        public override void Execute()
        {
            double a, b, c;
            double denom;
            string[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0]);
            b = double.Parse(valores[1]);
            c = double.Parse(valores[2]);

            double delta = Math.Pow(b, 2) - (4*a*c);
            denom = 2*a;
            if(delta < 0 || denom == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                delta = Math.Sqrt(delta);
                double x1 = ((-b)+delta)/denom;
                double x2 = ((-b)-delta)/denom;

                Console.WriteLine($"R1 = {x1:F5}");
                Console.WriteLine($"R2 = {x2:F5}");
            }
            
        }
    }
}