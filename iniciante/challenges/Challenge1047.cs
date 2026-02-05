using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1047 : BaseChallenge
    {
        public override void Execute()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int horaIni = int.Parse(valores[0]);
            int minuIni = int.Parse(valores[1]);
            int horaFin = int.Parse(valores[2]);
            int minuFin = int.Parse(valores[3]);

            int horas = 0;
            int minutos = 0;
            int auxHora = horaIni;
            int auxMinu = minuIni;

            while (true)
            {
                auxMinu++;
                minutos++;

                if(minutos > 59)
                {
                    minutos = 0;
                    horas++;
                }

                if(auxMinu > 59)
                {
                    auxMinu = 0;
                    auxHora++;
                    auxHora = auxHora > 23 ? 0 : auxHora;
                }

                if((auxHora == horaFin) && (auxMinu == minuFin)) break;
            }

            Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
        }
    }
}