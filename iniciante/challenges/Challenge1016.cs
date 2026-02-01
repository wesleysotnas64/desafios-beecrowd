using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1016 : BaseChallenge
    {
        public override void Execute()
        {
            int vm = 30;
            int ds = int.Parse(Console.ReadLine());
            int dt = (ds*60)/vm;
            Console.WriteLine($"{dt} minutos");
            
        }
    }
}