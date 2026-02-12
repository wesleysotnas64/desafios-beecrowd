using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1048 : BaseChallenge
    {
        public override void Execute()
        {
            double salario = double.Parse(Console.ReadLine());
            int percentual = PorcentagemReajuste(salario);
            double reajuste = salario * (percentual / 100.0);

            Console.WriteLine($"Novo salario: {salario+reajuste:F2}");
            Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
            Console.WriteLine($"Em percentual: {percentual} %");
        }

        public static int PorcentagemReajuste(double salario)
        {
            int porcentagem;
            if(salario > 0.00 && salario <= 400.00) porcentagem = 15;
            else if(salario > 400.00 && salario <= 800.00) porcentagem = 12;
            else if(salario > 800.00 && salario <= 1200.00) porcentagem = 10;
            else if(salario > 1200.00 && salario <= 2000.00) porcentagem = 7;
            else porcentagem = 4;
            return porcentagem;
        }
    }
}