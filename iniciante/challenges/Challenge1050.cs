using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1050 : BaseChallenge
    {
        public override void Execute()
        {
            Dictionary<string, string> dddTable = new Dictionary<string, string>()
            {
                {"61", "Brasilia"},
                {"71", "Salvador"},
                {"11", "Sao Paulo"},
                {"21", "Rio de Janeiro"},
                {"32", "Juiz de Fora"},
                {"19", "Campinas"},
                {"27", "Vitoria"},
                {"31", "Belo Horizonte"}
            };

            string ddd = Console.ReadLine();

            if (dddTable.ContainsKey(ddd))
            {
                Console.WriteLine(dddTable[ddd]);
            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }
        }
    }
}