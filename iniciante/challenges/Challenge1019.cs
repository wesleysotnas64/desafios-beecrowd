using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1019 : BaseChallenge
    {
        public override void Execute()
        {
            int segundos = int.Parse(Console.ReadLine());
            int minutos = segundos/60;
            segundos -= minutos*60;
            int horas = minutos/60;
            minutos -= horas*60;
            
            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}