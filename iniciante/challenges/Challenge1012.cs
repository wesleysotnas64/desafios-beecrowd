using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1012 : BaseChallenge
    {
        public override void Execute()
        {
            double a, b, c;
            double pi = 3.14159;
            string[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0]);
            b = double.Parse(valores[1]);
            c = double.Parse(valores[2]);
            double triangulo = (a*c)/2.0;
            double circulo = pi * Math.Pow(c, 2.0);
            double trapezio = ((a+b)*c)/2.0;
            double quadrado = Math.Pow(b, 2);
            double retangulo = a*b;

            Console.WriteLine($"TRIANGULO: {triangulo:F3}");
            Console.WriteLine($"CIRCULO: {circulo:F3}");
            Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
            Console.WriteLine($"QUADRADO: {quadrado:F3}");
            Console.WriteLine($"RETANGULO: {retangulo:F3}");
        }
        
    }
}