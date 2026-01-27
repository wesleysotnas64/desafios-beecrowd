using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1008 : BaseChallenge
    {
        public override void Execute()
        {
            int numeroFuncionario, horasTrabalhadas;
            double valorPorHora, salario;
            numeroFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorPorHora = double.Parse(Console.ReadLine());
            salario = horasTrabalhadas*valorPorHora;
            Console.WriteLine($"NUMBER = {numeroFuncionario}");
            Console.WriteLine($"SALARY = U$ {salario:F2}");
        }
    }
}