using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1009 : BaseChallenge
    {
        public override void Execute()
        {
            string nome;
            double salarioFixo, totalDeVendas, salario;
            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine());
            totalDeVendas = double.Parse(Console.ReadLine());
            salario = salarioFixo+(totalDeVendas*0.15);
            Console.WriteLine($"TOTAL = R$ {salario:F2}");
        }
    }
}