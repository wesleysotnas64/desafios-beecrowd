using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1038 : BaseChallenge
    {
        public override void Execute()
        {
            List<Item> items = new List<Item>();
            InitializeItems(items);

            string[] valores = Console.ReadLine().Split(' ');
            int codigoProd = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);
            
            double total = CalculaTotal(items, codigoProd, quantidade);

            Console.WriteLine($"Total: R$ {total:F2}");

        }

        public static void InitializeItems(List<Item> items)
        {
            items.Add(new Item(1, "Cachorro Quente", 4.00));
            items.Add(new Item(2, "X-Salada", 4.50));
            items.Add(new Item(3, "X-Bacon", 5.00));
            items.Add(new Item(4, "Torrada simples", 2.00));
            items.Add(new Item(5, "Refrigerante", 1.50));
        }

        public static double CalculaTotal(List<Item> items, int codigo, int quantidade)
        {
            double precoItem = 0;
            foreach(Item item in items)
            {
                if(item.Code() == codigo)
                {
                    precoItem = item.Price();
                    break;
                }
            }
            return precoItem*quantidade;
        }

    }

    public class Item
    {
        private int code;
        private string? name;
        private double price;

        public Item(){}
        public Item(int code, string name, double price)
        {
            Code(code);
            Name(name);
            Price(price);
        }

        public void Code(int code)
        {
            this.code = code;
        }
        public int Code()
        {
            return this.code;
        }
        public void Name(string name)
        {
            this.name = name;
        }
        public string Name()
        {
            return this.name;
        }
        public void Price(double price)
        {
            this.price = price;
        }
        public double Price()
        {
            return this.price;
        }
    }
}