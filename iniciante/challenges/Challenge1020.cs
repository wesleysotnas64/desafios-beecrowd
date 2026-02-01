using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1020 : BaseChallenge
    {
        public override void Execute()
        {
            int dias = int.Parse(Console.ReadLine());
            int anos = dias/365;
            dias -= anos*365;
            int meses = dias/30;
            dias -= meses*30;

            Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
        }
    }
}