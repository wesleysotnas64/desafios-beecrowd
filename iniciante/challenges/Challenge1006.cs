using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1006 : BaseChallenge
    {
        public override void Execute()
        {
            double a, b, c, media;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            media = ((2*a)+(3*b)+(5*c))/10.0;
            Console.WriteLine($"MEDIA = {media:F1}");
        }
    }
}