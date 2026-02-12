using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace iniciante.challenges
{
    public class Challenge1049 : BaseChallenge
    {
        public override void Execute()
        {
            Dictionary<string, string> animais = new Dictionary<string, string>()
            {
                { "vertebrado-ave-carnivoro", "aguia" },
                { "vertebrado-ave-onivoro", "pomba" },
                { "vertebrado-mamifero-onivoro", "homem" },
                { "vertebrado-mamifero-herbivoro", "vaca" },
                { "invertebrado-inseto-hematofago", "pulga" },
                { "invertebrado-inseto-herbivoro", "lagarta" },
                { "invertebrado-anelideo-hematofago", "sanguessuga" },
                { "invertebrado-anelideo-onivoro", "minhoca" }
            };

            string subfilo = Console.ReadLine()?.Trim();
            string classe = Console.ReadLine()?.Trim();
            string dieta = Console.ReadLine()?.Trim();

            string busca = subfilo + "-" + classe + "-" + dieta;

            if (animais.ContainsKey(busca)) {
                Console.WriteLine(animais[busca]);
            }
            
        }
    }
}