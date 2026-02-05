using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1046 : BaseChallenge
    {
        public override void Execute()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int inicio = int.Parse(valores[0]);
            int final = int.Parse(valores[1]);

            int horas = 0;
            int aux = inicio;
            do
            {
                aux++;
                horas++;
                if(aux > 23) aux = 0;
            }while(aux != final);
            Console.WriteLine($"O JOGO DUROU {horas} HORA(S)");
        }
    }
}