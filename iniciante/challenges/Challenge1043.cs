using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1043 : BaseChallenge
    {
        public override void Execute()
        {
            string[] valores = Console.ReadLine().Split(); 
            double a = double.Parse(valores[0]);
            double b = double.Parse(valores[1]);
            double c = double.Parse(valores[2]);

            if (EhTriangulo(a, b, c)) Console.WriteLine($"Perimetro = {a+b+c:F1}");
            else Console.WriteLine($"Area = {((a+b)*c)/2:F1}");
        }

        public static bool EhTriangulo(double a, double b, double c)
        {
            bool ehTriangulo = true;
            ehTriangulo = ((a+b)>c)&&ehTriangulo;
            ehTriangulo = ((a+c)>b)&&ehTriangulo;
            ehTriangulo = ((b+c)>a)&&ehTriangulo;
            return ehTriangulo;
        }
    }
}