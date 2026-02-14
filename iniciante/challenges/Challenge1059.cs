using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1059 : BaseChallenge
    {
        public override void Execute()
        {
            for(int i = 1; i <= 100; i++)
            {
                if(i%2==0) Console.WriteLine($"{i}");
            }
        }
    }
}