using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1018 : BaseChallenge
    {
        public override void Execute()
        {
            int[] notas = { 100, 50, 20, 10, 5, 2, 1 };
            
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) return;

            int valor = int.Parse(input);
            int restante = valor;

            Console.WriteLine(valor);

            foreach (int nota in notas) {
                int qtdNotas = restante / nota;
                Console.WriteLine($"{qtdNotas} nota(s) de R$ {nota},00");
                restante %= nota;
            }
        }
    }
}