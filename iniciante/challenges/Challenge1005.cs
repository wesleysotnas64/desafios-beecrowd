using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1005 : BaseChallenge
    {
        public override void Execute()
        {
            double a, b, media;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            media = ((a*3.5)+(b*7.5))/11.0;
            Console.WriteLine($"MEDIA = {media:F5}");
        }
    }
}