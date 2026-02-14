using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1051 : BaseChallenge
    {
        public override void Execute()
        {
            double salario = double.Parse(Console.ReadLine());
            double imposto = 0;

            if (salario <= 2000.00) {
                Console.WriteLine("Isento");
                return; // Encerra o programa
            }
            else if (salario <= 3000.00) {
                imposto = (salario - 2000.00) * 0.08;
            }
            else if (salario <= 4500.00) {
                // 8% sobre os 1000 da segunda faixa + 18% sobre o que passou de 3000
                imposto = (1000.00 * 0.08) + ((salario - 3000.00) * 0.18);
            }
            else {
                // 8% sobre os 1000 + 18% sobre os 1500 da terceira faixa + 28% sobre o resto
                imposto = (1000.00 * 0.08) + (1500.00 * 0.18) + ((salario - 4500.00) * 0.28);
            }

            Console.WriteLine($"R$ {imposto:F2}");
        }
    }
}