using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace iniciante.challenges
{
    public class Challenge1041 : BaseChallenge
    {
        public override void Execute()
        {
            string[] coord = Console.ReadLine().Split(' ');
            double x = double.Parse(coord[0]);
            double y = double.Parse(coord[1]);
            string msg = "";
            if(x == 0.0 && y == 0.0) msg = "Origem";
            else
            {
                if(x == 0) msg = "Eixo Y";
                else if(y == 0) msg = "Eixo X";
                else
                {
                    if(x > 0.0) msg = y > 0.0 ? "Q1":"Q4";
                    else if(x < 0.0) msg = y > 0.0 ? "Q2":"Q3";
                }
            }
            Console.WriteLine(msg);
        }
    }
}