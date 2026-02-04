using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1042 : BaseChallenge
    {
        public override void Execute()
        {
            string[] valores = Console.ReadLine().Split();
            int[] valoresOrdenados = Ordena(valores);

            foreach(int vo in valoresOrdenados) Console.WriteLine($"{vo}");
            Console.WriteLine();
            foreach(string v in valores) Console.WriteLine(v);
            
        }
        public static int[] Ordena(string[] valores)
        {
            int[] ordenado = new int[3];
            for(int i = 0; i < 3; i++) ordenado[i] = int.Parse(valores[i]);
            
            int auxIndex;
            int aux;
            for(int i = 1; i < 3; i++)
            {
                auxIndex = i;
                while(auxIndex > 0)
                {
                    if(ordenado[auxIndex] < ordenado[auxIndex - 1])
                    {
                        aux = ordenado[auxIndex - 1];
                        ordenado[auxIndex - 1] = ordenado[auxIndex];
                        ordenado[auxIndex] = aux;
                    }
                    else break;
                    
                    auxIndex--;
                }
            }

            return ordenado;
        }
    }

}