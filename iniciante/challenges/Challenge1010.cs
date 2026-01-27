using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1010 : BaseChallenge
    {
        public override void Execute()
        {
            
            int codigoPeca1, numeroDePecas1, codigoPeca2, numeroDePecas2;
            double valorPeca1, valorPeca2;
            string[] valoresPeca1 = Console.ReadLine().Split(' ');
            string[] valoresPeca2 = Console.ReadLine().Split(' ');
            codigoPeca1 = int.Parse(valoresPeca1[0]);
            numeroDePecas1 = int.Parse(valoresPeca1[1]);
            valorPeca1 = double.Parse(valoresPeca1[2]);
            codigoPeca2 = int.Parse(valoresPeca2[0]);
            numeroDePecas2 = int.Parse(valoresPeca2[1]);
            valorPeca2 = double.Parse(valoresPeca2[2]);
            Console.WriteLine($"VALOR A PAGAR: R$ {((numeroDePecas1*valorPeca1)+(numeroDePecas2*valorPeca2)):F2}");
        
        }
    }
}