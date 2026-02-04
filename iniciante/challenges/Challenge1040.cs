using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1040 : BaseChallenge
    {
        public override void Execute()
        {
            CultureInfo culture = CultureInfo.InvariantCulture;

            string[] valores = Console.ReadLine().Split(' ');
            float n1 = float.Parse(valores[0], culture);
            float n2 = float.Parse(valores[1], culture);
            float n3 = float.Parse(valores[2], culture);
            float n4 = float.Parse(valores[3], culture);

            float media = (float)((n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10.0);
            
            media = (float)(Math.Floor(media * 10) / 10.0);

            Console.WriteLine($"Media: {media.ToString("F1", culture)}");

            if (media >= 7.0f) {
                Console.WriteLine("Aluno aprovado.");
            } 
            else if (media < 5.0f) {
                Console.WriteLine("Aluno reprovado.");
            } 
            else {
                Console.WriteLine("Aluno em exame.");
                
                float notaExame = float.Parse(Console.ReadLine(), culture);
                Console.WriteLine($"Nota do exame: {notaExame.ToString("F1", culture)}");

                float mediaFinal = (media + notaExame) / 2;

                if (mediaFinal >= 5.0f) {
                    Console.WriteLine("Aluno aprovado.");
                } else {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine($"Media final: {mediaFinal.ToString("F1", culture)}");

            }
        }
    }
}