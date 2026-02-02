using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1021 : BaseChallenge
    {
        public override void Execute()
        {
            int[] notas = { 100, 50, 20, 10, 5, 2};
            double[] moedas = { 100, 50, 25, 10, 5, 1 }; //Em centavos
            double valor = double.Parse(Console.ReadLine());
            double restante = valor;
            int qtd;

            Console.WriteLine("NOTAS:");
            foreach(int nota in notas)
            {
                qtd = ((int)restante)/nota;
                Console.WriteLine($"{qtd} nota(s) de R$ {nota}.00");
                restante -= qtd*nota;
            }

            int centavos = (int)(restante*100);
            Console.WriteLine("MOEDAS:");
            foreach(int moeda in moedas)
            {
                qtd = centavos/moeda;
                Console.WriteLine($"{qtd} moeda(s) de R$ {((double)moeda/100):F2}", System.Globalization.CultureInfo.InvariantCulture);
                centavos -= qtd*moeda;
            }
            
        }
    }
}